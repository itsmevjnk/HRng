/*
 * LibTests.cs - Program for testing libraries (modules) in HRng backend.
 * Created on: 30-11-2021 20:46
 * Author    : itsmevjnk
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

using HRngBackend;

namespace LibTests
{
    class MainProgram
    {
        /*
         * static Stopwatch ProgressStopwatch
         *   Stopwatch instance for progress indicator.
         */
        static Stopwatch stopwatch = new Stopwatch();

        /*
         * static int ProgressIndicator(int current, int total)
         *   A simple progress indicator callback function.
         *   Input : current: Current number of processed items.
         *           total  : Total number of items to be processed.
         *   Output: 0.
         */
        static int ProgressIndicator(int current, int total)
        {
            stopwatch.Stop();
            Console.WriteLine($"{100 * ((float) current / (float) total)}% ({current}/{total}). Execution time: {stopwatch.ElapsedMilliseconds}ms");
            stopwatch.Restart(); stopwatch.Start();
            return 0;
        }

        /*
         * static async Task<int> Main()
         *   The main function.
         *   Input : none.
         *   Output: the return value.
         */
        static async Task<int> Main()
        {
            Console.WriteLine("HRng Libraries Test\n");

            /* CSV loading test */
            Console.Write("Input CSV file: "); string infile = Console.ReadLine();
            Spreadsheet sheet = CSV.FromFile(infile);
            Console.WriteLine("Spreadsheet contents:");
            foreach (var cell in sheet.Data) Console.WriteLine($"{sheet.Address(cell.Key)}: {cell.Value.Replace(Environment.NewLine, "<NL>")}");
            sheet.Update(sheet.Index("D10"), $"Hello, World!{Environment.NewLine}HRng Libraries Test");
            Console.Write("Output CSV file: "); string outfile = Console.ReadLine();
            CSV.ToFile(sheet, outfile);
            Console.WriteLine($"CSV file rewritten to {outfile}");

            /* FakeUA test */
            Console.WriteLine("15 randomly generated User-Agent strings:");
            for (int i = 0; i < 15; i++) Console.WriteLine($"{i+1}: " + UserAgent.Next());
            Console.WriteLine();

            /* GetUID test */
            Console.WriteLine("GetHandle() test:");
            string[] uid_handle_tests =
            {
                "https://www.facebook.com/asdf",
                "www.facebook.com/asdf",
                "m.facebook.com/profile.php?id=1234",
                "m.me/1234",
                "messenger.com/t/1234",
                "m.facebook.com/home.php/asdf",
                "/profile.php?id=1345&refid=_tn_"
            };
            foreach(string t in uid_handle_tests)
            {
                Console.WriteLine(t + " => " + UID.GetHandle(t));
            }
            Console.WriteLine();

            Console.WriteLine("UID retrieval test:");
            Console.Write("Facebook profile link to retrieve UID: "); string link = Console.ReadLine();
            Console.Write("UID: "); Console.WriteLine(await UID.Get(link));
            Console.WriteLine();

            /* OSCombo test */
            Console.WriteLine($"OS-architecture combo: {OSCombo.Combo}");
            Console.WriteLine();

            /* SevenZip test */
            if (SevenZip.Exists()) Console.WriteLine($"7za exists at {SevenZip.BinaryPath}");
            else
            {
                Console.Write("Initializing 7za...");
                await SevenZip.Initialize();
                Console.WriteLine("done.");
            }

            /* ChromeHelper test */
            ChromeHelper chrome = new ChromeHelper();
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
            Console.Write("Updating Chromium and/or ChromeDriver...");
            if (await chrome.Update() != 0) Console.WriteLine("failed.");
            else Console.WriteLine("done.");
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
            while (true)
            {
                Console.WriteLine($"Options for Facebook post {post.PostID}:");
                Console.WriteLine("1. Get all reactions");
                Console.WriteLine("2. Get all comments");
                Console.WriteLine("3. Get all shares");
                Console.WriteLine("4. Clear UID cache");
                Console.WriteLine("5. Go to next test");
                Console.Write("Please select an option: "); int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Getting all reactions...");
                    var reactions = await post.GetReactions(ProgressIndicator);
                    Console.WriteLine("Finished getting reactions.");
                    foreach (var reaction_kvp in reactions)
                    {
                        var reaction = reaction_kvp.Value;
                        Console.WriteLine($"{reaction.UserID} ({reaction.UserName}): {reaction.Reaction}");
                    }
                    Console.WriteLine();
                }

                if (option == 2)
                {
                    Console.WriteLine("Getting all comments...");
                    var comments = await post.GetComments(ProgressIndicator);
                    Console.WriteLine("Finished getting comments.");
                    foreach (var comment_kvp in comments)
                    {
                        var comment = comment_kvp.Value;
                        Console.Write($"Comment ID {comment.ID}:");
                        if (comment.Parent != -1) Console.WriteLine($" reply of {comment.Parent}"); else Console.WriteLine();
                        Console.WriteLine($"  Author: {comment.AuthorID} ({comment.AuthorName})");
                        Console.WriteLine($"  Text (HTML): {comment.CommentText_HTML}");
                        if (comment.Mentions.Count != 0) Console.WriteLine($"  Mentions: {String.Join(", ", comment.Mentions)}");
                        if (comment.EmbedURL != "") Console.WriteLine($"  External link: {comment.EmbedURL} ({comment.EmbedTitle})");
                        if (comment.ImageURL != "") Console.WriteLine($"  Image: {comment.ImageURL}");
                        if (comment.VideoURL != "") Console.WriteLine($"  Video: {comment.VideoURL}");
                        if (comment.StickerURL != "") Console.WriteLine($"  Sticker: {comment.StickerURL}");
                        Console.WriteLine();
                    }
                }

                if (option == 3)
                {
                    Console.WriteLine("Getting all accounts that shared this post...");
                    var shares = await post.GetShares(ProgressIndicator);
                    Console.WriteLine("Finished getting accounts.");
                    foreach (var share_kvp in shares) Console.WriteLine($"{share_kvp.Key} ({share_kvp.Value})");
                    Console.WriteLine();
                }

                if (option == 4)
                {
                    UID.ClearCache();
                    Console.WriteLine("Cleared UID cache");
                    Console.WriteLine();
                }

                if (option == 5) break;
            }
            
            Console.WriteLine("Tests completed. Press Enter to stop.");
            Console.ReadLine();
            driver.Quit();
            return 0;
        }
    }
}
