/*
 * CommonHTTP.cs - For having one HttpClient instance for the whole
 *                 library - exactly how Microsoft wanted us to use
 *                 it.
 * Created on: 23:56 26-12-2021
 * Author    : itsmevjnk
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace HRngBackend
{
    public static class CommonHTTP
    {
        /*
         * public static HttpClientHandler ClientHandler
         *   HTTP client handler instance, used for things such as
         *   cookies.
         */
        public static HttpClientHandler ClientHandler = new HttpClientHandler();

        /*
         * public static HttpClient Client
         *   HTTP client instance, where virtually anything HTTP-based
         *   will be done.
         */
        public static HttpClient Client = new HttpClient(ClientHandler);

        /*
         * static CommonHTTP()
         *   Constructor for this class. Prepares Client and ClientHandler.
         */
        static CommonHTTP()
        {
            Client.DefaultRequestHeaders.Add("User-Agent", UserAgent.Next()); // Set up a random User-Agent for Client, so that services like GitHub can work
            if (ClientHandler.CookieContainer == null) ClientHandler.CookieContainer = new CookieContainer(); // Set up CookieContainer
        }

        /*
         * public static void AddCookie(string domain, string key, string value)
         *   Add a cookie.
         *   Input : domain    : The domain to which the cookie is added.
         *           key, value: The cookie's key and value.
         *   Output: none.
         */
        public static void AddCookie(string domain, string key, string value)
        {
            Cookie cookie = new Cookie(); // The proper cookie object to be added into CookieContainer

            cookie.Name = key; cookie.Value = value; // Insert the key and value, very straightforward part
            cookie.Domain = "." + domain; cookie.Path = "/";
            ClientHandler.CookieContainer.Add(cookie); // Add to the cookies collection
        }

        /*
         * public static void AddCookies(string domain, IDictionary<string, string> cookies)
         *   Add multiple cookies stored in a <string, string> dictionary.
         *   Input : domain : The domain to which the cookies will be added.
         *           cookies: The <string, string> dictionary containg the
         *                    cookies to be added.
         *   Output: none.
         */
        public static void AddCookies(string domain, IDictionary<string, string> cookies)
        {
            foreach (var cookie in cookies) AddCookie(domain, cookie.Key, cookie.Value);
        }

        /*
         * public static void ClearCookies(string domain)
         *   Clear cookies for a domain.
         *   Input : domain: The domain of which the cookies will be
         *                   deleted.
         *   Output: none.
         */
        public static void ClearCookies(string domain)
        {
            foreach (Cookie cookie in ClientHandler.CookieContainer.GetCookies(new Uri($"http://{domain}")))
            {
                cookie.Expired = true; // Set cookie to expired
            }
        }

        /*
         * public static void ClearAllCookies()
         *   Clear all cookies from all domains.
         *   Input : none.
         *   Output: none.
         */
        public static void ClearAllCookies()
        {
            ClientHandler.CookieContainer = new CookieContainer();
        }
    }
}
