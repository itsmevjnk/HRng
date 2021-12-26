/*
 * LibTests.cs - Program for testing libraries (modules) in HRng backend.
 * Created on: 30-11-2021 20:46
 * Author    : itsmevjnk
 */

using System;
using System.IO;
using System.Threading.Tasks;

using HRngBackend;

namespace LibTests
{
    class MainProgram
    {
        static async Task<int> Main()
        {
            Console.WriteLine("HRng Libraries Test\n");

            /* FakeUA test */
            Console.WriteLine("15 randomly generated User-Agent strings:");
            for (int i = 0; i < 15; i++) Console.WriteLine($"{i+1}: " + UserAgent.Next());
            Console.WriteLine();

            /* GetUID test */
            UID uid = new UID();

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
                Console.WriteLine(t + " => " + uid.GetHandle(t));
            }
            Console.WriteLine();

            Console.WriteLine("UID retrieval test:");
            Console.Write("Facebook profile link to retrieve UID: "); string link = Console.ReadLine();
            Console.Write("UID: "); Console.WriteLine(await uid.Get(link));
            Console.WriteLine();

            Console.WriteLine($"OS-architecture combo: {OSCombo.Combo}");
            Console.WriteLine();

            if (SevenZip.Exists()) Console.WriteLine($"7za exists at {SevenZip.BinaryPath}");
            else
            {
                Console.Write("Initializing 7za...");
                await SevenZip.Initialize();
                Console.WriteLine("done.");
            }

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
            Console.WriteLine("Press Enter to close browser.");
            Console.ReadLine();
            driver.Quit();

            Console.WriteLine("Tests completed");
            Console.ReadLine();
            return 0;
        }
    }
}
