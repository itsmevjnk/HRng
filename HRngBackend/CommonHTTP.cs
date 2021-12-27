/*
 * CommonHTTP.cs - For having one HttpClient instance for the whole
 *                 library - exactly how Microsoft wanted us to use
 *                 it.
 * Created on: 23:56 26-12-2021
 * Author    : itsmevjnk
 */

using System.Net.Http;

namespace HRngBackend
{
    internal static class CommonHTTP
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
            if (ClientHandler.CookieContainer == null) ClientHandler.CookieContainer = new System.Net.CookieContainer(); // Set up CookieContainer
        }
    }
}
