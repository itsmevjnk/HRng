/*
 * LibTests.cs - Program for testing libraries (modules) in HRng backend.
 * Created on: 30-11-2021 20:46
 * Author    : itsmevjnk
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using HRngBackend;
using HRngSelenium;
using HRngLite;

namespace LibTests
{
    class MainProgram
    {
        /// <summary>
        ///  A simple progress indicator callback function.
        /// </summary>
        /// <param name="perc">The current percentage.</param>
        /// <returns>true.</returns>
        static bool ProgressIndicator(float perc)
        {
            Console.SetCursorPosition(0, Console.CursorTop); Console.WriteLine($"{perc}%");
            return true;
        }

        /// <summary>
        ///  Remove the quote characters surrounding the path.
        /// </summary>
        /// <param name="path">The path to be processed.</param>
        /// <returns>The processed path.</returns>
        static string CleanPath(string path)
        {
            if (path[0] == '"' && path[path.Length - 1] == '"') path = path.Substring(1, path.Length - 2);
            else if (path[0] == '\'' && path[path.Length - 1] == '\'') path = path.Substring(1, path.Length - 2);
            return path;
        }

        /// <summary>
        ///  The main function.
        /// </summary>
        /// <returns>the return value.</returns>
        static async Task<int> Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("HRng Libraries Test\n");

            Stopwatch watch = new Stopwatch(); // For measuring operation time

            Console.Write("Use HRngLite instead of HRngSelenium? (y/n*) ");
            bool use_lite = (Console.ReadLine().ToLower() == "y");

            IFBPost post; // For FBPost test

            /* Initialize FB reaction type lookup table */
            Console.Write("Retrieving reaction type LUT...");
            await FBReactUtil.GetLut();
            Console.WriteLine("done.");

            if (!use_lite)
            {
                /* SevenZip test */
                if (SevenZip.Exists()) Console.WriteLine($"7za exists at {SevenZip.BinaryPath}");
                else
                {
                    Console.Write("Initializing 7za...");
                    await SevenZip.Initialize();
                    Console.WriteLine("done.");
                }

                /* IBrowserHelper test */
                Console.Write("Attempt to detect existing browser installations? (y*/n) ");
                string browser_detect_str = Console.ReadLine().ToLower();
                bool browser_detect = (browser_detect_str == "") || (browser_detect_str == "y");
                IBrowserHelper browser = null;
                while (browser == null)
                {
                    Console.Write("Which browser do you want to use, ");
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && browser_detect) Console.Write("(C)hrome, (F)irefox, or (S)afari? (c/f/s) ");
                    else Console.Write("(C)hrome or (F)irefox? (c/f) ");
                    string browser_str = Console.ReadLine().ToLower();
                    switch (browser_str)
                    {
                        case "c": browser = new ChromeHelper(browser_detect); break;
                        case "f": browser = new FirefoxHelper(browser_detect); break;
                        case "s": browser = new SafariHelper(); break;
                    }
                }
                Console.WriteLine("Browser initialized");
                if(browser is SafariHelper)
                {
                    Console.WriteLine("!!! WARNING !!!");
                    Console.WriteLine("You have selected to use Safari. Please make sure that remote automation is enabled.");
                    Console.WriteLine("For more information, refer to this link:");
                    Console.WriteLine("  https://developer.apple.com/documentation/webkit/testing_with_webdriver_in_safari");
                    Console.Write("Press RETURN to continue...");
                    Console.ReadLine();
                }
                else
                {
                    if (browser_detect)
                    {
                        if (File.Exists(browser.BrowserPath)) Console.WriteLine($"Detected browser at {browser.BrowserPath}, version {browser.LocalVersion()} ({((browser.BrowserInst) ? "installed" : "downloaded by HRng")})");
                        else Console.WriteLine("Cannot detect browser");
                    }
                    if (File.Exists(browser.DriverPath)) Console.WriteLine($"Detected browser driver at {browser.DriverPath}, version {browser.LocalDriverVersion()}");
                    else Console.WriteLine("Cannot detect browser driver");
                    string browser_ver = (File.Exists(browser.BrowserPath)) ? browser.LocalVersion() : "";
                    Task<Release> latest_browser_task = null, latest_driver_task;
                    Release r_browser = null, r_driver;
                    if (browser_ver != "")
                    {
                        latest_driver_task = browser.LatestDriverRelease(browser_ver);
                        latest_browser_task = browser.LatestRelease();
                    } else
                    {
                        r_browser = await browser.LatestRelease();
                        browser_ver = r_browser.Version;
                        latest_driver_task = browser.LatestDriverRelease(browser_ver);
                    }
                    if (latest_browser_task != null) r_browser = await latest_browser_task;
                    if (r_browser != null) Console.WriteLine($"Latest browser version: {r_browser.Version}, download URL: {r_browser.DownloadURL}, updatable: {r_browser.Update}");
                    else Console.WriteLine("Cannot get latest Chromium version");
                    r_driver = await latest_driver_task;
                    if (r_driver != null) Console.WriteLine($"Latest driver version for browser version {browser_ver}: {r_driver.Version}, download URL: {r_driver.DownloadURL}, updatable: {r_driver.Update}");
                    else Console.WriteLine($"Cannot get latest driver version for browser version {browser_ver}");
                    Console.WriteLine("Updating browser and driver...");
                    if (await browser.Update(cb: ProgressIndicator) != 0) Console.WriteLine("Updating failed.");
                    else Console.WriteLine("Updating completed.");
                }
                Console.Write("Starting browser...");
                var driver = browser.InitializeSelenium(headless: false);
                Console.WriteLine("done.");

                /* Cookies/FBLogin test */
                while (true)
                {
                    Console.Write("Log in using cookies? (y*/n) ");
                    string opt = Console.ReadLine().ToLower();
                    var cookies = new Dictionary<string, string>();
                    if (opt == "y" || opt == "")
                    {
                        Console.Write("Facebook cookies: "); cookies = Cookies.FromKVPString(Console.ReadLine());
                        CommonHTTP.AddCookies("facebook.com", cookies); SeCookies.LoadCookies(driver, cookies, "https://m.facebook.com");
                    }
                    else
                    {
                        Console.Write("Email or phone number: "); var email = Console.ReadLine();
                        Console.Write("Password: "); var password = Console.ReadLine(); // We might need password masking here
                        Console.Write("Logging in..."); int ret = HRngSelenium.FBLogin.Login(driver, email, password, cookies);
                        if (ret == 0) Console.WriteLine("done.");
                        else if (ret == -3)
                        {
                            Console.WriteLine("two-factor authentication required.");
                            while (true)
                            {
                                Console.Write("Approve login from another device? (y*/n) ");
                                opt = Console.ReadLine().ToLower();
                                if (opt == "y" || opt == "")
                                {
                                    Console.Write("Please approve the login in 30 seconds...");
                                    ret = HRngSelenium.FBLogin.LoginOTP(driver, cookies: cookies, timeout: 30);
                                    if (ret == 0 || ret == -1) Console.WriteLine("done.");
                                    else if (ret == -3)
                                    {
                                        Console.WriteLine("timed out.");
                                        continue;
                                    }
                                    else Console.WriteLine($"LoginOTP() failed (return code {ret})");
                                    break;
                                }
                                else
                                {
                                    Console.Write("Enter the OTP: "); string otp = Console.ReadLine();
                                    Console.Write("Submitting the OTP...");
                                    ret = HRngSelenium.FBLogin.LoginOTP(driver, otp, cookies);
                                    if (ret == 0 || ret == -1) Console.WriteLine("done.");
                                    else if (ret == -4) Console.WriteLine("incorrect OTP.");
                                    else Console.WriteLine($"LoginOTP() failed (return code {ret})");
                                    break;
                                }
                            }
                        }
                        else Console.WriteLine($"Login() failed (return code {ret})");
                    }

                    if (HRngSelenium.FBLogin.VerifyLogin(driver))
                    {
                        Console.WriteLine("Account logged in");
                        break;
                    }
                    else Console.WriteLine("Account login failed");
                }

                post = new HRngSelenium.FBPost(driver);
            }
            else
            {
                /* Cookies/FBLogin test */
                while (true)
                {
                    Console.Write("Log in using cookies? (y*/n) ");
                    string opt = Console.ReadLine().ToLower();
                    var cookies = new Dictionary<string, string>();
                    if (opt == "y" || opt == "")
                    {
                        Console.Write("Facebook cookies: "); cookies = Cookies.FromKVPString(Console.ReadLine());
                        CommonHTTP.AddCookies("facebook.com", cookies);
                    }
                    else
                    {
                        Console.Write("Email or phone number: "); var email = Console.ReadLine();
                        Console.Write("Password: "); var password = Console.ReadLine(); // We might need password masking here
                        Console.Write("Logging in..."); int ret = await HRngLite.FBLogin.Login(email, password, cookies);
                        if (ret == 0) Console.WriteLine("done.");
                        else if (ret == -3)
                        {
                            Console.WriteLine("two-factor authentication required.");
                            while (true)
                            {
                                Console.Write("Enter the OTP: "); string otp = Console.ReadLine();
                                Console.Write("Submitting the OTP...");
                                ret = await HRngLite.FBLogin.LoginOTP(otp, cookies);
                                if (ret == 0 || ret == -1) Console.WriteLine("done.");
                                else if (ret == -4) Console.WriteLine("incorrect OTP.");
                                else Console.WriteLine($"LoginOTP() failed (return code {ret})");
                                break;
                            }
                        }
                        else Console.WriteLine($"Login() failed (return code {ret})");
                    }

                    if (await HRngLite.FBLogin.VerifyLogin())
                    {
                        Console.WriteLine("Account logged in");
                        break;
                    }
                    else Console.WriteLine("Account login failed");
                }

                post = new HRngLite.FBPost();
            }
            
            /* FBPost test */
            Console.Write("Facebook post link: "); string post_url = Console.ReadLine();
            Console.Write("Initializing..."); Console.WriteLine($"done (returns {await post.Initialize(post_url)}).");
            Console.WriteLine($"Author ID: {post.AuthorID}, post ID: {post.PostID}, is group post: {post.IsGroupPost}");

            /* CSV/ExcelWorkbook -> Spreadsheet -> EntryCollection test */
            bool? input_type = null; // true for CSV, false for XLS*
            while (input_type == null)
            {
                Console.Write("Which type of input file do you want to use, (C)SV or E(x)cel (XLS/XLSX/XLSB)? (c/x) ");
                string input_str = Console.ReadLine().ToLower();
                switch (input_str)
                {
                    case "c": input_type = true; break;
                    case "x": input_type = false; break;
                }
            }
            Console.Write($"Input {((input_type == true) ? "CSV" : "XLS*")} file: "); string infile = CleanPath(Console.ReadLine());
            EntryCollection ec = new EntryCollection();
            watch.Start();
            if (input_type == true) ec.FromSpreadsheet(CSV.FromFile(infile));
            else
            {
                var sheets = ExcelWorkbook.FromFile(infile);
                watch.Stop();
                Console.WriteLine("List of sheets in the workbook:");
                for (int i = 0; i < sheets.Count; i++) Console.WriteLine($"{i}: {sheets[i].Key}");
                Console.Write("Enter the sheet that you want to load (default: 0): ");
                string sheet_str = Console.ReadLine();
                watch.Start();
                ec.FromSpreadsheet(sheets[(sheet_str == "") ? 0 : Convert.ToInt32(sheet_str)].Value);
            }
            watch.Stop();
            Console.WriteLine($"Loading took {watch.ElapsedMilliseconds}ms"); watch.Reset();
            int col_react = ec.AddColumn("Reactions");
            int col_react_log = ec.AddColumn("Reactions (detailed)");
            int col_cmt_cnt = ec.AddColumn("Comments");
            int col_cmt_text = ec.AddColumn("Comment text");
            int col_ment_cnt = ec.AddColumn("Mentions");
            int col_ment_uid = ec.AddColumn("Mentioned UID(s)");
            int col_share = ec.AddColumn("Shares");
            int col_share_log = ec.AddColumn("Accounts used to share");

            /* FBPost/EntryCollection test */
            while (true)
            {
                Console.WriteLine($"Options for Facebook post {post.PostID}:");
                Console.WriteLine("1. Get all reactions");
                Console.WriteLine("2. Get all comments");
                Console.WriteLine("3. Get all shares");
                Console.WriteLine("4. Clear UID cache");
                Console.WriteLine("5. Print EntryCollection");
                Console.WriteLine("6. Go to next test");
                Console.Write("Please select an option: "); int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Getting all reactions...");
                    watch.Start(); var reactions = await post.GetReactions(ProgressIndicator); watch.Stop();
                    Console.WriteLine("Finished getting reactions.");
                    foreach (var reaction_kvp in reactions)
                    {
                        var reaction = reaction_kvp.Value;
                        Console.WriteLine($"{reaction.UserID} ({reaction.UserName}): {reaction.Reaction}");
                    }

                    Stopwatch watch2 = new Stopwatch();
                    watch2.Start(); ec.CountReactions(reactions.Values.ToList(), col_react, col_react_log); watch2.Stop();
                    Console.WriteLine($"Counting took {watch2.ElapsedMilliseconds}ms");
                }

                if (option == 2)
                {
                    Console.Write("Perform Pass 1? (y*/n) "); string pass = Console.ReadLine().ToLower();
                    bool p1 = (pass != "n");
                    Console.Write("Perform Pass 2? (y*/n) "); pass = Console.ReadLine().ToLower();
                    bool p2 = (pass != "n");
                    Console.WriteLine("Getting all comments...");
                    watch.Start(); var comments = await post.GetComments(ProgressIndicator, p1: p1, p2: p2); watch.Stop();
                    Console.WriteLine($"Finished getting {comments.Count} comment(s).");
                    foreach (var comment_kvp in comments)
                    {
                        var comment = comment_kvp.Value;
                        Console.Write($"Comment ID {comment.ID}:");
                        if (comment.Parent != -1) Console.WriteLine($" reply of {comment.Parent}"); else Console.WriteLine();
                        Console.WriteLine($"  Author: {comment.AuthorID} ({comment.AuthorName})");
                        Console.WriteLine($"  Text (HTML): {comment.CommentText_HTML}");
                        if (comment.Mentions_UID.Count != 0) Console.WriteLine($"  Mentions: {String.Join(", ", comment.Mentions_UID)}");
                        if (comment.EmbedURL != "") Console.WriteLine($"  External link: {comment.EmbedURL} ({comment.EmbedTitle})");
                        if (comment.ImageURL != "") Console.WriteLine($"  Image: {comment.ImageURL}");
                        if (comment.VideoURL != "") Console.WriteLine($"  Video: {comment.VideoURL}");
                        if (comment.StickerURL != "") Console.WriteLine($"  Sticker: {comment.StickerURL}");
                        Console.WriteLine();
                    }

                    Stopwatch watch2 = new Stopwatch();
                    watch2.Start(); ec.CountComments(comments.Values.ToList(), col_cmt_cnt, col_cmt_text, col_ment: col_ment_cnt, col_mdet: col_ment_uid); watch2.Stop();
                    Console.WriteLine($"Counting took {watch2.ElapsedMilliseconds}ms");
                }

                if (option == 3)
                {
                    Console.WriteLine("Getting all accounts that shared this post...");
                    watch.Start(); var shares = await post.GetShares(ProgressIndicator); watch.Stop();
                    Console.WriteLine("Finished getting accounts.");
                    foreach (var share_kvp in shares) Console.WriteLine($"{share_kvp.Key} ({share_kvp.Value})");

                    Stopwatch watch2 = new Stopwatch();
                    watch2.Start(); ec.CountShares(shares.Keys.ToList(), col_share, col_share_log); watch2.Stop();
                    Console.WriteLine($"Counting took {watch2.ElapsedMilliseconds}ms");
                }

                if (option == 4)
                {
                    watch.Start(); UID.ClearCache(); watch.Stop();
                    Console.WriteLine("Cleared UID cache");
                }

                if (option == 5)
                {
                    watch.Start();
                    foreach (var entry in ec.Entries)
                    {
                        Console.WriteLine($"UID {String.Join(", ", entry.UID)}:");
                        foreach (var p in entry.Data)
                        {
                            Console.WriteLine($"  Col {p.Key} ({ec.Headers[p.Key]}): {p.Value}");
                        }
                        Console.WriteLine();
                    }
                    watch.Stop();
                }

                if (option == 6) break;

                Console.WriteLine($"Operation took {watch.ElapsedMilliseconds}ms");
                Console.WriteLine();
                watch.Reset();
            }

            /* EntryCollection -> Spreadsheet -> CSV test */
            Console.Write("Output CSV file: "); string outfile = CleanPath(Console.ReadLine());
            watch.Start(); CSV.ToFile(ec.ToSpreadsheet(), outfile); watch.Stop();
            Console.WriteLine($"Saving took {watch.ElapsedMilliseconds}ms"); watch.Reset();

            Console.WriteLine("Tests completed. Press Enter to stop.");
            Console.ReadLine();
            return 0;
        }
    }
}
