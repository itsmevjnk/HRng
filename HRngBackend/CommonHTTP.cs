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
using System.Threading.Tasks;
using System.IO;

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
            Client.Timeout = TimeSpan.FromSeconds(30); // Set timeout to 30 seconds
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

        /*
         * public static async Task<bool> DownloadFile(string url, string output,
         *                                             [Func<float, bool> cb])
         *   Downloads a file.
         *   Input : url   : The URL of the file to be downloaded.
         *           output: The path to the output file.
         *           cb    : The callback function to be called every 1/100th of the
         *                   file has been downloaded, as well as at the beginning and
         *                   the end (optional).
         *                   This function takes the current percentage and returns
         *                   false if the user cancelled the downloading process or
         *                   true otherwise.
         *   Output: false if the user cancelled downloading, or true on success.
         */
        public static async Task<bool> DownloadFile(string url, string output, Func<float, bool>? cb = null)
        {
            var resp = await Client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
            resp.EnsureSuccessStatusCode();

            var total_bytes = resp.Content.Headers.ContentLength; // TODO: Does total_bytes=null mean that the server doesn't provide the file size?
            if (cb != null && cb((total_bytes == null) ? float.NaN : 0) == false) return false;

            long read_bytes = 0; // Number of bytes read
            var buffer = new byte[8192]; // Buffer to store downloaded data

            long read_bytes_perc = 0; // Number of bytes read before next percent callback
            using (var outstream = new FileStream(output, FileMode.Create, FileAccess.Write, FileShare.None, buffer.Length, true))
            {
                using (var instream = await resp.Content.ReadAsStreamAsync())
                {
                    while (true)
                    {
                        var n = await instream.ReadAsync(buffer, 0, buffer.Length);
                        if (n == 0) break;
                        await outstream.WriteAsync(buffer, 0, n);

                        if (cb != null && total_bytes != null)
                        {
                            read_bytes_perc += n; read_bytes += n;
                            if (read_bytes_perc >= (total_bytes / 100))
                            {
                                read_bytes_perc = 0;
                                if (cb(100 * ((float)read_bytes / (float)total_bytes)) == false) return false;
                            }
                        }
                    }
                }
            }

            if (cb != null) cb(100); // At this point it's already too late to return
            return true;
        }
    }
}
