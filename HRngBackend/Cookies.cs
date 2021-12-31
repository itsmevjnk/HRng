/*
 * Cookies.cs - Functions for handling web cookies.
 * Created on: 12:25 27-12-2021
 * Author    : itsmevjnk
 */

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;

#nullable enable
namespace HRngBackend
{
    public static class Cookies
    {
        /*
         * public static IDictionary<string, string>? FromKVPString(string kvpstr, [char kvsep], [char psep])
         *   Parse a key-value pair string of <key>=<value>; form into a
         *   string => string dictionary.
         *   Input : kvpstr: Key-value pair string.
         *           kvsep : Key-value separator character (optional).
         *                   Defaults to = (equal).
         *           psep  : Pair separator character (optional).
         *                   Defaults to ; (semicolon).
         *   Output: A string => string dictionary containing the parsed
         *           cookies, or null if parsing fails.
         */
        public static IDictionary<string, string>? FromKVPString(string kvpstr, char kvsep = '=', char psep = ';')
        {
            kvpstr = kvpstr.Replace(" ", ""); // Remove all whitespaces
            IDictionary<string, string> cookies = new Dictionary<string, string> { };
            foreach (string kvp in kvpstr.Split(psep, StringSplitOptions.RemoveEmptyEntries))
            {
                string[] pair = kvp.Split(kvsep);
                if (pair.Length != 2) return null; // Invalid pair
                cookies.Add(pair[0], pair[1]);
            }
            return cookies;
        }

        /*
         * public static IDictionary<string, string>? FromTxt_String(string txtstr)
         *   Parse a string containing Netscape formatted cookies
         *   (also known as cookies.txt) into a string => string
         *   dictionary.
         *   Input : txtstr: The input string containing data from
         *                   the cookies.txt-formatted file.
         *   Output: A string => string dictionary containing the parsed
         *           cookies, or null if parsing fails.
         */
        public static IDictionary<string, string>? FromTxt_String(string txtstr)
        {
            IDictionary<string, string> cookies = new Dictionary<string, string> { };
            foreach (string line in txtstr.Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)) // We don't need \r\n and \n\r since those will be split into an empty string, and deleted by the RemoveEmptyEntries option
            {
                if (line.StartsWith('#')) continue; // Skip comment lines
                string[] components = line.Split('\t'); // Tab delmited
                if (components.Length >= 7) cookies.Add(components[5], components[6]); // We only need the key and value
                else return null; // Parsing failed
            }
            return cookies;
        }

        /*
         * public static IDictionary<string, string>? FromTxt_File(string path)
         *   Parse a Netscape formatted cookies file (aka cookies.txt)
         *   into a string => string dictionary.
         *   Input : path: Path to the cookies.txt-formatted file.
         *   Output: A string => string dictionary containing the parsed
         *           cookies, or null if parsing fails.
         */
        public static IDictionary<string, string>? FromTxt_File(string path)
        {
            return FromTxt_String(File.ReadAllText(path));
        }

        /*
         * public static void Se_LoadCookie(IWebDriver driver, string key, string value, string url = "")
         *   Load a single cookie to a Selenium browser session.
         *   Input : driver: The driver instance for the Selenium browser
         *                   session.
         *           key   : The cookie's key.
         *           value : The cookie's value.
         *           url   : URL to the domain for which the cookie will
         *                   be stored for (optional). If specified, this
         *                   function will load the web page before setting
         *                   the cookie.
         *   Output: none.
         */
        public static void Se_LoadCookie(IWebDriver driver, string key, string value, string url = "")
        {
            if (url != "" && driver.Url != url) driver.Navigate().GoToUrl(url);
            driver.Manage().Cookies.AddCookie(new Cookie(key, value));
        }

        /*
         * public static void Se_LoadCookies(IWebDriver driver, IDictionary<string, string> cookies, string url = "")
         *   Load a string => string dictionary containing cookies to a
         *   Selenium browser session.
         *   Input : driver : The driver instance for the Selenium browser
         *                    session.
         *           cookies: The string => string dictionary containing the
         *                    cookies.
         *           url    : URL to the domain for which the cookies will
         *                    be stored for (optional). If specified, this
         *                    function will load the web page before setting
         *                    the cookies.
         *   Output: none.
         */
        public static void Se_LoadCookies(IWebDriver driver, IDictionary<string, string> cookies, string url = "")
        {
            if (url != "" && driver.Url != url) driver.Navigate().GoToUrl(url);
            foreach (var item in cookies) driver.Manage().Cookies.AddCookie(new Cookie(item.Key, item.Value));
        }

        /*
         * public static void Se_ClearCookies(IWebDriver driver, string url = "")
         *   Clear all cookies for a domain in a Selenium browser session.
         *   Input : driver: The driver instance for the Selenium browser
         *                   session.
         *           url   : URL to the domain of which the cookies will be
         *                   deleted (optional). If specified, this function
         *                   will load the web page before clearing the cookies.
         *   Output: none.
         */
        public static void Se_ClearCookies(IWebDriver driver, string url = "")
        {
            if (url != "" && driver.Url != url) driver.Navigate().GoToUrl(url);
            driver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
#nullable disable
