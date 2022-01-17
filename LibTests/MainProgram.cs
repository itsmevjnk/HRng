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

using HRngBackend;

namespace LibTests
{
    class MainProgram
    {
        /*
         * static bool ProgressIndicator(float perc)
         *   A simple progress indicator callback function.
         *   Input : perc: The current percentage.
         *   Output: true.
         */
        static bool ProgressIndicator(float perc)
        {
            Console.SetCursorPosition(0, Console.CursorTop); Console.WriteLine($"{perc}%");
            return true;
        }

        /*
         * static string CleanPath(string path)
         *   Remove the quote characters surrounding the path.
         *   Input : path: The path to be processed.
         *   Output: The processed path.
         */
        static string CleanPath(string path)
        {
            if (path[0] == '"' && path[path.Length - 1] == '"') path = path.Substring(1, path.Length - 2);
            return path;
        }

        /*
         * static async Task<int> Main()
         *   The main function.
         *   Input : none.
         *   Output: the return value.
         */
        static async Task<int> Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("HRng Libraries Test\n");

            Stopwatch watch = new Stopwatch(); // For measuring operation time

            /* SevenZip test */
            if (SevenZip.Exists()) Console.WriteLine($"7za exists at {SevenZip.BinaryPath}");
            else
            {
                Console.Write("Initializing 7za...");
                await SevenZip.Initialize();
                Console.WriteLine("done.");
            }

            /* ChromeHelper test */
            Console.Write("Attempt to detect existing Chrome installations? (y*/n) ");
            string detect = Console.ReadLine().ToLower();
            ChromeHelper chrome = new ChromeHelper((detect == "" || detect == "y"));
            Console.WriteLine("ChromeHelper initialized");
            if (chrome.ChromeInst) Console.WriteLine($"Local Chrome/Chromium installation detected at {chrome.ChromePath}, version {chrome.LocalVersion()}");
            else if (File.Exists(chrome.ChromePath)) Console.WriteLine($"Self-downloaded Chromium installation detected at {chrome.ChromePath}, version {chrome.LocalVersion()}");
            else Console.WriteLine("Cannot detect Chrome/Chromium installations");
            if (File.Exists(chrome.ChromeDriverPath)) Console.WriteLine($"Self-downloaded ChromeDriver detected at {chrome.ChromeDriverPath}, version {chrome.LocalDriverVersion()}");
            else Console.WriteLine("Cannot detect ChromeDriver");
            string chrome_ver = (File.Exists(chrome.ChromePath)) ? chrome.LocalVersion() : "";
            Task<Release> latest_browser_task = null, latest_driver_task;
            Release crbrowser = null, crdriver;
            if (chrome_ver != "")
            {
                latest_driver_task = chrome.LatestDriverRelease(chrome_ver);
                latest_browser_task = chrome.LatestRelease();
            } else
            {
                crbrowser = await chrome.LatestRelease();
                chrome_ver = crbrowser.Version;
                latest_driver_task = chrome.LatestDriverRelease(chrome_ver);
            }
            if (latest_browser_task != null) crbrowser = await latest_browser_task;
            if (crbrowser != null) Console.WriteLine($"Latest Chromium version: {crbrowser.Version}, download URL: {crbrowser.DownloadURL}, updatable: {crbrowser.Update}");
            else Console.WriteLine("Cannot get latest Chromium version");
            crdriver = await latest_driver_task;
            if (crdriver != null) Console.WriteLine($"Latest ChromeDriver version for Chrome/Chromium {chrome_ver}: {crdriver.Version}, download URL: {crdriver.DownloadURL}, updatable: {crdriver.Update}");
            else Console.WriteLine($"Cannot get latest ChromeDriver version for Chrome/Chromium {chrome_ver}");
            Console.WriteLine("Updating Chromium and/or ChromeDriver...");
            if (await chrome.Update(cb: ProgressIndicator) != 0) Console.WriteLine("Updating failed.");
            else Console.WriteLine("Updating completed.");
            Console.Write("Starting Chrome/Chromium...");
            var driver = chrome.InitializeSelenium(headless: false);
            Console.WriteLine("done.");

            /* FBPost/Cookies test */
            Console.Write("Facebook cookies: "); var cookies = Cookies.FromKVPString(Console.ReadLine());
            CommonHTTP.AddCookies("facebook.com", cookies); Cookies.Se_LoadCookies(driver, cookies, "https://m.facebook.com");
            FBPost post = new FBPost(driver);
            Console.Write("Facebook post link: "); string post_url = Console.ReadLine();
            Console.Write("Initializing..."); Console.WriteLine($"done (returns {await post.Initialize(post_url)}).");
            Console.WriteLine($"Author ID: {post.AuthorID}, post ID: {post.PostID}, is group post: {post.IsGroupPost}");

            /* CSV -> Spreadsheet -> EntryCollection test */
            Console.Write("Input CSV file: "); string infile = CleanPath(Console.ReadLine());
            EntryCollection ec = new EntryCollection();
            watch.Start(); ec.FromSpreadsheet(CSV.FromFile(infile)); watch.Stop();
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
                    Console.WriteLine("Getting all comments...");
                    watch.Start(); var comments = await post.GetComments(ProgressIndicator); watch.Stop();
                    Console.WriteLine("Finished getting comments.");
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
            driver.Quit();
            return 0;
        }
    }
}
