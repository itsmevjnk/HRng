/*
 * LibTests.cs - Program for testing libraries (modules) in HRng backend.
 * Created on: 30-11-2021 20:46
 * Author    : itsmevjnk
 */

using System;
using System.Threading.Tasks;

/* Our libraries */
using FakeUA;
using GetUID;

namespace LibTests
{
    class MainProgram
    {
        static async Task<int> Main()
        {
            Console.WriteLine("HRng Libraries Test\n");

            /* FakeUA test */
            UserAgent ua = new UserAgent();
            Console.WriteLine("15 randomly generated User-Agent strings:");
            for (int i = 0; i < 15; i++) Console.WriteLine($"{i+1}: " + ua.Next());
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

            Console.WriteLine("Tests completed");
            return 0;
        }
    }
}
