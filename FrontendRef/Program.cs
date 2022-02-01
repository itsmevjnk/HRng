/*
 * Program.cs - The frontend reference implementation's main program
 *              code.
 * Created on: 10:08 20-01-2022
 * Author    : itsmevjnk
 */

using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Linq;
using System.Text;

using HRngBackend;

namespace FrontendRef
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"HRng FrontendRef {Assembly.GetExecutingAssembly().GetName().Version}");
            Console.WriteLine();

            /* Custom lightweight command argument parser */
            HashSet<string> orders = new HashSet<string>(); // List of orders
            string? browser = null; // The browser to be used for executing orders
            bool headless = false; // Whether the browser is started headlessly
            do
            {
                char? escape = null; // Escape character for the current parsing argument
                string order = ""; // Currently parsing order
                foreach (var arg in args)
                {
                    if (escape == null && (arg.StartsWith('"') || arg.StartsWith('\'') || arg.StartsWith('\'')))
                    {
                        /* Begin of an order with spaces */
                        escape = order[0];
                        order = arg.Substring(1);
                    }
                    else if (escape != null && arg.EndsWith((char)escape))
                    {
                        /* End of an order with spaces */
                        escape = null;
                        order += arg.Remove(arg.Length - 1);
                        if (!File.Exists(order)) Console.WriteLine($"Order {order} does not exist, skipping");
                        else orders.Add(order);
                    }
                    else if (arg.StartsWith("--"))
                    {
                        /* Other options */
                        string option = arg.Substring(2).ToLower();
                        if (option == "chrome" || option == "firefox") browser = option;
                        if (option == "headless") headless = true;
                    }
                    else
                    {
                        /* Order without spaces */
                        if (!File.Exists(arg)) Console.WriteLine($"Order {arg} does not exist, skipping");
                        else orders.Add(arg);
                    }
                }
            } while (false); // So we can reuse variable names

            /* Handle invalid scenarios */
            if (browser == null)
            {
                Console.WriteLine("Browser not specified. Available browser arguments are --chrome and --firefox.");
                return 1;
            }
            if (browser != "chrome" && browser != "firefox")
            {
                Console.WriteLine("Invalid browser. Available arguments are --chrome and --firefox.");
                return 1;
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("No orders to execute.");
                return 1;
            }

            /* Initialize 7-Zip */
            if (SevenZip.Exists()) Console.WriteLine($"7za exists at {SevenZip.BinaryPath}");
            else
            {
                Console.Write("Initializing 7za...");
                await SevenZip.Initialize();
                Console.WriteLine("done.");
            }

            /* Initialize browser */
            IBrowserHelper bhelper = null;
            if (browser == "chrome") bhelper = new ChromeHelper();
            else bhelper = new FirefoxHelper();
            if (File.Exists(bhelper.BrowserPath)) Console.WriteLine($"Detected browser at {bhelper.BrowserPath}, version {bhelper.LocalVersion()} ({((bhelper.BrowserInst) ? "installed" : "downloaded by HRng")})");
            else Console.WriteLine("Cannot detect browser");
            if (File.Exists(bhelper.DriverPath)) Console.WriteLine($"Detected browser driver at {bhelper.DriverPath}, version {bhelper.LocalDriverVersion()}");
            else Console.WriteLine("Cannot detect browser driver");
            Console.Write("Updating browser and driver... ");
            int ret;
            using (var progress = new Progress())
            {
                ret = await bhelper.Update(cb: progress.Update);
            }
            if (ret == 0) Console.WriteLine("done.");
            else
            {
                Console.WriteLine($"failed (returned {ret}).");
                return 1;
            }
            Console.Write("Starting browser... ");
            var driver = bhelper.InitializeSelenium(headless: headless);
            Console.WriteLine("done.");

            /* Process orders */
            int n = 0;
            var post = new FBPost(driver);
            foreach (var fname in orders)
            {
                Console.WriteLine($"Processing order {++n}/{orders.Count}: {fname}");
                var order = new XmlDocument(); order.Load(fname);

                /* Get elements of the order */
                var input = order.DocumentElement.SelectSingleNode("//input");
                if (input == null || input.Attributes["path"] == null)
                {
                    Console.WriteLine("ERROR: Input file not specified, skipping");
                    goto next;
                }
                var login = order.DocumentElement.SelectSingleNode("//login");
                if (login == null || login.Attributes["type"] == null)
                {
                    Console.WriteLine("ERROR: Login information not specified, skipping");
                    goto next;
                }
                var post_node = order.DocumentElement.SelectSingleNode("//post");
                if (post_node == null || post_node.Attributes["url"] == null)
                {
                    Console.WriteLine("ERROR: Facebook post not specified, skipping");
                    goto next;
                }
                var actions = order.DocumentElement.SelectSingleNode("//actions");
                if (actions == null)
                {
                    Console.WriteLine("ERROR: Actions not specified, skipping");
                    goto next;
                }
                var output = order.DocumentElement.SelectSingleNode("//output");
                if (output == null || output.Attributes["path"] == null)
                {
                    Console.WriteLine("ERROR: Output file not specified, skipping");
                    goto next;
                }

                /* Load input CSV/XLS/XLSX file */
                if (!File.Exists(input.Attributes["path"].Value))
                {
                    Console.WriteLine("Input file does not exist, skipping");
                    goto next;
                }
                var ec = new EntryCollection();
                string input_fname = input.Attributes["path"].Value;
                string col_uid = "UID";
                if (input.Attributes["uid"] != null) col_uid = input.Attributes["uid"].Value;
                Spreadsheet sheet = null;
                if (Path.GetExtension(input_fname).ToLower().StartsWith(".xls"))
                {
                    int snum = -1;
                    string? sname = null;
                    if (input.Attributes["snum"] != null) snum = Convert.ToInt32(input.Attributes["snum"].Value);
                    if (input.Attributes["sname"] != null) sname = input.Attributes["sname"].Value;
                    var sheets = ExcelWorkbook.FromFile(input_fname);
                    if (snum != -1)
                    {
                        if (snum < 0 || snum >= sheets.Count)
                        {
                            Console.WriteLine($"Invalid sheet number {snum}, will load first sheet instead.");
                            snum = 0;
                        }
                        sheet = sheets[snum].Value;
                    }
                    else if (sname != null)
                    {
                        foreach (var kvp in sheets)
                        {
                            if (kvp.Key == sname)
                            {
                                sheet = kvp.Value;
                                break;
                            }
                        }
                        if (sheet == null)
                        {
                            Console.WriteLine($"Workbook does not contain sheet {sname}, will load first sheet instead.");
                            sheet = sheets[0].Value;
                        }
                    }
                    else sheet = sheets[0].Value;
                }
                else sheet = CSV.FromFile(input_fname);
                ec.FromSpreadsheet(sheet, uid_name: col_uid);
                Console.WriteLine($"Loaded input from {input_fname} (UID column name: {col_uid})");

                /* Process login */
                driver.Manage().Cookies.DeleteAllCookies();
                var cookies = new Dictionary<string, string>();
                switch (login.Attributes["type"].Value)
                {
                    case "cookies-kvp": // Cookies based login (key-value pair string)
                        cookies = Cookies.FromKVPString(login.Attributes["cookies"].Value);
                        break;
                    case "cookies-txt": // Cookies based login (cookies.txt)
                        cookies = Cookies.FromTxt_File(login.Attributes["path"].Value);
                        break;
                    case "credentials": // Credentials based login
                        ret = FBLogin.Login(driver, login.Attributes["email"].Value, login.Attributes["password"].Value, cookies);
                        if (ret != 0)
                        {
                            if (ret == -3)
                            {
                                Console.WriteLine("Two-factor authentication is required.");
                                Console.Write("Enter the OTP, or approve the login from another device and press Enter: ");
                                ret = FBLogin.LoginOTP(driver, Console.ReadLine(), cookies);
                                if (ret != 0 && ret != -1)
                                {
                                    Console.WriteLine($"Two-factor login failed (returned {ret}), skipping");
                                    goto next;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Login failed (returned {ret}), skipping");
                                goto next;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine($"Unknown login method {login.Attributes["type"].Value}, skipping");
                        goto next;
                }
                CommonHTTP.ClearCookies("facebook.com"); CommonHTTP.AddCookies("facebook.com", cookies);
                if (login.Attributes["type"].Value != "credentials")
                {
                    Cookies.Se_LoadCookies(driver, cookies, "https://m.facebook.com");
                    if (!FBLogin.VerifyLogin(driver))
                    {
                        Console.WriteLine("Account login failed, skipping");
                        goto next;
                    }
                }
                Console.WriteLine("Account has been logged in");

                /* Load Facebook post */
                ret = await post.Initialize(post_node.Attributes["url"].Value);
                if (ret != 0)
                {
                    Console.WriteLine($"Post loading failed (returned {ret}), skipping");
                    goto next;
                }
                Console.WriteLine($"Author ID: {post.AuthorID}, post ID: {post.PostID}, is group post: {post.IsGroupPost}");

                /* Execute action(s) */
                var actlist = actions.SelectNodes("./action");
                if (actlist == null)
                {
                    Console.WriteLine("No actions to be executed, skipping");
                    goto next;
                }
                int nact = 0;
                Dictionary<int, int> col_conditions = new Dictionary<int, int>(); // List of minimum count for each count column to be checked if summary action is called
                foreach (XmlNode action in actlist)
                {
                    if (action.Attributes["type"] == null)
                    {
                        Console.WriteLine($"Action {++nact}/{actlist.Count} does not have type, ignoring");
                        continue;
                    }
                    Console.Write($"Action {++nact}/{actlist.Count}: ");
                    switch (action.Attributes["type"].Value)
                    {
                        case "react":
                            Console.WriteLine("Check reactions");
                            {
                                string col_name = "Reactions";
                                if (action.Attributes["count"] != null) col_name = action.Attributes["count"].Value;
                                Console.WriteLine($" Reaction count column name: {col_name}");
                                int col = ec.AddColumn(col_name);

                                int col_details = -1;
                                if (action.Attributes["details"] != null)
                                {
                                    col_name = action.Attributes["details"].Value;
                                    Console.WriteLine($" Reaction details column name: {col_name}");
                                    col_details = ec.AddColumn(col_name);
                                }

                                int min = 1;
                                if (action.Attributes["min"] != null) min = Convert.ToInt32(action.Attributes["min"].Value);
                                Console.WriteLine($" Minimum reaction count: {min}");
                                col_conditions.Add(col, min);

                                Console.Write($" Running action... ");
                                using (var progress = new Progress())
                                {
                                    ec.CountReactions((await post.GetReactions(progress.Update)).Values.ToList(), col, col_details);
                                }
                                Console.WriteLine("done.");
                            }
                            break;
                        case "comment":
                            Console.WriteLine("Check comments and mentions");
                            {
                                string col_name = "Comments";
                                if (action.Attributes["count"] != null) col_name = action.Attributes["count"].Value;
                                Console.WriteLine($" Comment count column name: {col_name}");
                                int col = ec.AddColumn(col_name);

                                int col_ctext = -1;
                                if (action.Attributes["ctext"] != null)
                                {
                                    col_name = action.Attributes["ctext"].Value;
                                    Console.WriteLine($" Comment text column name: {col_name}");
                                    col_ctext = ec.AddColumn(col_name);
                                }

                                int min = 1;
                                if (action.Attributes["min"] != null) min = Convert.ToInt32(action.Attributes["min"].Value);
                                Console.WriteLine($" Minimum comment count: {min}");
                                col_conditions.Add(col, min);

                                bool replies = false;
                                if (action.Attributes["replies"] != null && action.Attributes["replies"].Value.ToLower() == "true") replies = true;
                                Console.WriteLine($" Count comment replies: {replies}");

                                int col_mcount = -1;
                                int col_muid = -1;
                                bool m_exclude = true;
                                if (action.Attributes["mcount"] != null)
                                {
                                    col_name = action.Attributes["mcount"].Value;
                                    Console.WriteLine($" Mention count column name: {col_name}");
                                    col_mcount = ec.AddColumn(col_name);

                                    min = 1;
                                    if (action.Attributes["mmin"] != null) min = Convert.ToInt32(action.Attributes["mmin"].Value);
                                    Console.WriteLine($" Minimum mention count: {min}");
                                    col_conditions.Add(col_mcount, min);
                                    if (action.Attributes["muid"] != null)
                                    {
                                        col_name = action.Attributes["muid"].Value;
                                        Console.WriteLine($" Mentioned UID(s) column name: {col_name}");
                                        col_muid = ec.AddColumn(col_name);
                                    }

                                    if (action.Attributes["mexclude"] != null && action.Attributes["mexclude"].Value.ToLower() == "false") m_exclude = false;
                                    Console.WriteLine($" Exclude existing UIDs in the input list from mentions: {m_exclude}");
                                }

                                bool p1 = true, p2 = false;
                                if (action.Attributes["p1"] != null && action.Attributes["p1"].Value.ToLower() == "false") p1 = false;
                                if (action.Attributes["p2"] != null && action.Attributes["p2"].Value.ToLower() == "true") p2 = true;
                                Console.WriteLine($" Pass(es): {((p1) ? "1 " : "")}{((p2) ? "2 " : "")}");

                                Console.Write($" Running action... ");
                                using (var progress = new Progress())
                                {
                                    ec.CountComments((await post.GetComments(progress.Update, p1: p1, p2: p2)).Values.ToList(), col, col_ctext, col_ment: col_mcount, col_mdet: col_muid, ment_exc: m_exclude, replies: replies);
                                }
                                Console.WriteLine("done.");
                            }
                            break;
                        case "share":
                            Console.WriteLine("Check shares");
                            {
                                string col_name = "Shares";
                                if (action.Attributes["count"] != null) col_name = action.Attributes["count"].Value;
                                Console.WriteLine($" Share count column name: {col_name}");
                                int col = ec.AddColumn(col_name);

                                int col_details = -1;
                                if (action.Attributes["details"] != null)
                                {
                                    col_name = action.Attributes["details"].Value;
                                    Console.WriteLine($" Share details column name: {col_name}");
                                    col_details = ec.AddColumn(col_name);
                                }

                                int min = 1;
                                if (action.Attributes["min"] != null) min = Convert.ToInt32(action.Attributes["min"].Value);
                                Console.WriteLine($" Minimum share count: {min}");
                                col_conditions.Add(col, min);

                                Console.Write($" Running action... ");
                                using (var progress = new Progress())
                                {
                                    ec.CountShares((await post.GetShares(progress.Update)).Keys.ToList(), col, col_details);
                                }
                                Console.WriteLine("done.");
                            }
                            break;
                        case "summary":
                            Console.WriteLine($" Summarize retrieved data");
                            {
                                string col_name = "Summary";
                                if (action.Attributes["col"] != null) col_name = action.Attributes["col"].Value;
                                Console.WriteLine($" Summary column name: {col_name}");
                                int col = ec.AddColumn(col_name);

                                string stat_done = "Completed";
                                if (action.Attributes["done"] != null) stat_done = action.Attributes["done"].Value;
                                Console.WriteLine($" Completed status string: {stat_done}");

                                string stat_partial = "Partially completed";
                                if (action.Attributes["partial"] != null) stat_partial = action.Attributes["partial"].Value;
                                Console.WriteLine($" Partially completed status string: {stat_partial}");

                                string stat_notdone = "Not completed";
                                if (action.Attributes["notdone"] != null) stat_notdone = action.Attributes["notdone"].Value;
                                Console.WriteLine($" Not completed status string: {stat_notdone}");

                                Console.Write(" Running action... ");
                                using (var progress = new Progress())
                                {
                                    int nentry = 0;
                                    foreach (var entry in ec.Entries)
                                    {
                                        List<int> diff = new List<int>(); // List of differences in each row compared to minimum above
                                        foreach (var c in col_conditions) diff.Add(entry.IntData[c.Key] - c.Value);
                                        string stat = stat_notdone;
                                        if (diff.All(x => (x >= 0))) stat = stat_done;
                                        else if (diff.Any(x => (x >= 0))) stat = stat_partial;
                                        entry.Data[col] = stat;
                                        nentry++;
                                        progress.Update((float)nentry / (float)ec.Entries.Count);
                                    }
                                }
                                Console.WriteLine("Done.");
                            }
                            break;
                        default:
                            Console.WriteLine($"Unknown action {action.Attributes["type"].Value}, ignoring");
                            break;
                    }
                }

                /* Save output */
                string out_fname = output.Attributes["path"].Value;
                CSV.ToFile(ec.ToSpreadsheet(), out_fname);
                Console.WriteLine($"Output saved to {out_fname}");

            next:
                Console.WriteLine(); // Separate between orders
            }

            /* Close browser */
            driver.Quit();

            return 0;
        }
    }
}
