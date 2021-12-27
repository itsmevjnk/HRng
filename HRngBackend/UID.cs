/*
 * UID.cs - Facebook user ID (UID) retrieval functions.
 * Created on: 00:09 01-12-2021
 * Author    : itsmevjnk
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using HtmlAgilityPack;

namespace HRngBackend
{
    public class UID
    {
        /*
         * public IDictionary<string, long> Cache
         *   User name to UID cache.
         *   While it's possible to read and write directly from this dictionary,
         *   this is not recommended, and improper use may result in undefined
         *   behavior. Use Add() and Get() to insert and retrieve UIDs, and use
         *   ClearCache() to clear the cache.
         */
        public IDictionary<string, long> Cache = new Dictionary<string, long>();

        /*
         * public string GetHandle(string link)
         *   Process a Facebook profile link and retrieve the profile's handle.
         *   A handle is our extension of the Facebook user name, and can be either:
         *    - the user name (if one exists in the link)
         *    - :[UID] (if the UID exists instead of the user name, e.g.
         *              https://www.facebook.com/profile.php?id=[UID])
         *   Input : link: A [string] variable containing the Facebook profile link.
         *   Output: The handle in [string] type, or "" if the passed URL is invalid.
         */
        public string GetHandle(string link)
        {
            link = Regex.Replace(link, "^.*://", ""); // Remove the schema (aka http(s)://) from the link

            if (link == "") return ""; // Totally invalid link

            /* Split the link up into elements */
            string[] link_elements = link.ToLower().Split("/").Where(x => !String.IsNullOrEmpty(x)).ToArray(); // Use LINQ to handle removal of empty elements
            if(link_elements.Length == 1)
            {
                /* We probably get a link in the form of [/]profile.php or [/](UID/user name), i.e. not even a link */
                string[] query = link_elements[0].Split('?');
                if (query.Length == 0) return ""; // Invalid URL
                if (query[0] == "profile.php")
                {
                    if (query.Length == 1) return ""; // No parameters present
                    foreach (string q in query[1].Split('&'))
                    {
                        if (q.StartsWith("id=") && q.Length > "id=".Length && q.Substring("id=".Length).All(char.IsDigit)) return ":" + q.Substring("id=".Length);
                    }
                    return ""; // Cannot find id= parameter
                } else
                {
                    if (query[0].All(char.IsDigit)) return ":" + query[0]; // UID
                    else return query[0];
                }
            }
            /* 
             * Now the first element contains the domain name, and we can use it to
             * determine if it's a valid link
             */
            if(link_elements[0].EndsWith("m.me"))
            {
                /* m.me/(UID or user name) */
                if (link_elements[1].All(char.IsDigit)) return ":" + link_elements[1]; // UID
                else return link_elements[1];
            } else
            {
                string[] domain = link_elements[0].Split('.'); // We also split it here
                if (Array.IndexOf(domain, "facebook") > -1)
                {
                    /* facebook.com */
                    link_elements = link_elements.Where(x => x != "home.php").ToArray(); // Remove possible home.php element
                    string[] query = link_elements[1].Split('?'); // Split parameter from path
                    if (query.Length == 0) return ""; // There's nothing at all
                    if (query[0] == "profile.php")
                    {
                        /* profile.php with parameter id=(UID) */
                        if (query.Length == 1) return ""; // No parameters present
                        foreach (string q in query[1].Split('&'))
                        {
                            if (q.StartsWith("id=") && q.Length > "id=".Length && q.Substring("id=".Length).All(char.IsDigit)) return ":" + q.Substring("id=".Length);
                        }
                        return ""; // Cannot find id= parameter
                    }
                    else
                    {
                        /* User name */
                        return query[0];
                    }
                }
                else if (Array.IndexOf(domain, "messenger") > -1)
                {
                    /* messenger.com */
                    link_elements = link_elements.Where(x => x != "t").ToArray(); // Remove possible /t/ element
                    if (link_elements[1].All(char.IsDigit)) return ":" + link_elements[1]; // UID
                    else return link_elements[1];
                }
                else return ""; // Invalid URL
            }
        }

        /*
         * public bool Add(string link, long uid)
         *   Processes the link to get the handle, then add an entry to the UID
         *   cache. If the link already has the UID as part of it, this function
         *   will still return [true], but no entries will be added.
         *   Input : link: The Facebook profile link.
         *           uid : The UID that is associated with it.
         *   Output: true  if the entry can be added.
         *           false if the link or UID is invalid.
         */
        public bool Add(string link, long uid)
        {
            if (uid <= 0) return false; // Invalid UID

            string handle = GetHandle(link);
            if (handle == "") return false; // Cannot get handle due to invalid URL
            if (handle.StartsWith(':')) return true; // Handle is UID, we don't need to put it in cache

            AddHandle(handle, uid);
            return true;
        }

        /*
         * private void AddHandle(string handle, long uid)
         *   Adds an entry to the UID cache by handle.
         *   Input : handle: The Facebook profile handle.
         *           uid   : The UID that is associated with it.
         *   Output: none.
         */
        private void AddHandle(string handle, long uid)
        {
            foreach (var item in Cache.Where(kvp => kvp.Value == uid).ToList()) Cache.Remove(item.Key); // Remove all existing cache entries with our UID since each UID can only be associated with an user name
            Cache.Add(handle, uid); // Add to cache
        }

        /*
         * public void ClearCache()
         *   Clears the UID cache.
         *   Input : none.
         *   Output: none.
         */
        public void ClearCache()
        {
            Cache.Clear();
        }
        
        /*
         * public void AddCookie(string key, string value)
         *   Add a cookie for logging into Facebook.
         *   Input : key, value: The cookie's key and value.
         *   Output: none.
         */
        public void AddCookie(string key, string value)
        {
            Cookie cookie = new Cookie(); // The proper cookie object to be added into CookieContainer

            cookie.Name = key; cookie.Value = value; // Insert the key and value, very straightforward part
            cookie.Domain = ".facebook.com"; cookie.Path = "/"; // Indicates this cookie is for *.facebook.com/*

            if (CommonHTTP.ClientHandler.CookieContainer == null) CommonHTTP.ClientHandler.CookieContainer = new CookieContainer();
            CommonHTTP.ClientHandler.CookieContainer.Add(cookie); // Add to the Facebook cookies collection
        }

        /*
         * public void AddCookies(IDictionary<string, string> cookies)
         *   Add multiple cookies stored in a <string, string> dictionary to
         *   the Facebook login cookies.
         *   Input : cookies: The <string, string> dictionary containg the
         *                    cookies to be added.
         *   Output: none.
         */
        public void AddCookies(IDictionary<string, string> cookies)
        {
            foreach (var cookie in cookies) AddCookie(cookie.Key, cookie.Value);
        }

        /*
         * public void ClearCookies()
         *   Clear the Facebook login cookies.
         *   Input : none.
         *   Output: none.
         */
        public void ClearCookies()
        {
            CommonHTTP.ClientHandler.CookieContainer = new CookieContainer();
        }

        

        /*
         * private async static Task<long> LookupUID(string service_url,
         *                                           IDictionary<string, string> data,
         *                                           string xpath,
         *                                           [CancellationToken ctoken])
         *   Private helper function for looking up UID from services.
         *   This function sends a POST request with data specified in [data] to
         *   the service specified in [service_url], then retrieves the UID using
         *   the XPath specified in [xpath] and converts it to a [long] integer.
         *   Input : service_url: URL of the lookup service used.
         *           data       : POST request data.
         *           xpath      : XPath pointing to the element containing the UID
         *                        returned by the service.
         *           ctoken     : Cancellation token for cancelling the task (optional).
         *   Output: The retrieved UID, or -1 on failure.
         *           If ctoken is specified, -2 will be returned if the task is
         *           cancelled.
         */
        private async static Task<long> LookupUID(string service_url, IDictionary<string, string> data, string xpath, CancellationToken? ctoken = null)
        {
            var rq_content = new FormUrlEncodedContent(data); // POST request data, converted to work with HttpClient
            for (int i = 0; i < 3 && (ctoken == null || !((CancellationToken)ctoken).IsCancellationRequested); i++) // retry for 3 times at most
            {
                /* Send POST request to service */
                string response_data = "";
                try
                {
                    HttpRequestMessage request_msg = new HttpRequestMessage // For custom User-Agent
                    {
                        Method = HttpMethod.Post,
                        RequestUri = new Uri(service_url),
                        Headers =
                        {
                            { HttpRequestHeader.UserAgent.ToString(), UserAgent.Next() }
                        },
                        Content = rq_content
                    };
                    if (ctoken == null)
                    {
                        var response = await CommonHTTP.Client.SendAsync(request_msg); // Perform POST request
                        response.EnsureSuccessStatusCode();
                        response_data = await response.Content.ReadAsStringAsync();
                    } else
                    {
                        CancellationToken token = (CancellationToken) ctoken;
                        var response = await CommonHTTP.Client.SendAsync(request_msg, cancellationToken: token); // Perform POST request with cancellation token
                        response.EnsureSuccessStatusCode();
                        response_data = await response.Content.ReadAsStringAsync();
                    }
                } catch (Exception exc)
                {
                    if (ctoken != null && exc.GetType().IsAssignableFrom(typeof(TaskCanceledException)) && ((CancellationToken)ctoken).IsCancellationRequested) return -2; // Task cancelled
                    continue;
                }

                /* Load and parse output */
                var htmldoc = new HtmlDocument();
                htmldoc.LoadHtml(response_data);
#nullable enable // So that the compiler is happy with what we do
                HtmlNode? uid_node = htmldoc.DocumentNode.SelectSingleNode(xpath);
#nullable disable
                if (uid_node == null) continue;
                string uid = uid_node.InnerText;
                if (uid.All(char.IsDigit)) return Convert.ToInt64(uid);
            }
            if (ctoken != null && ((CancellationToken) ctoken).IsCancellationRequested) return -2; // Task cancelled
            return -1; // Cannot retrieve UID
        }

        /*
         * public async Task<long> Get(string link)
         *   The main function of this library. This function attempts to retrieve
         *   the UID of a Facebook link using these methods:
         *    - Getting UID directly from link
         *    - Cache lookup
         *    - Lookup using existing UID lookup services
         *    - Scraping from profile page (if Facebook login information is provided)
         *   Input : link: The Facebook profile link to try to get its UID.
         *   Output: The profile's UID, or one of these values on failure:
         *            -1: Invalid link
         *            -2: Cannot retrieve UID using any of the available methods
         *            -3: Cannot retrieve UID, but it might be possible to do so using
         *                the last method (i.e. we have no login information)
         *            -4: Cannot retrieve UID because the provided Facebook account
         *                has been ratelimited
         *            -5: Cannot retrieve UID because the provided Facebook cookies
         *                is invalid (i.e. signed out)
         */
        public async Task<long> Get(string link)
        {
            string handle = GetHandle(link); // From now on we will work with this handle
            if (handle == "") return -1; // Invalid link

            if (handle.StartsWith(':')) return Convert.ToInt64(handle.Substring(1)); // Return the UID if it can be found in the link

            if (Cache.ContainsKey(handle)) return Cache[handle]; // Return the UID from cache if available

            /* Online retrieval */
            long uid = -1; // Retrieved UID, used at the end for adding into cache and returning

            /* Attempt retrieval using lookup services */
            link = $"https://www.facebook.com/{handle}";
            (string url, IDictionary<string, string> data, string xpath)[] services =
            {
                ("https://id.atpsoftware.vn/", new Dictionary<string, string>{ { "linkCheckUid", link } }, "//div[@id='menu1']/textarea"),
                ("https://findidfb.com/#", new Dictionary<string, string>{ { "url", link } }, "//div[@class='alert alert-success alert-dismissable']/b"),
                ("https://lookup-id.com/#", new Dictionary<string, string>{ { "fburl", link }, { "check", "Lookup" } }, "//span[@id='code']")
                /* TODO: Add more services. The more services we have in here, the more chance we have at getting UIDs without ratelimiting the user. */
            };
            IList<Task<long>> svc_tasks = new List<Task<long>> { }; // Lookup task pool
            IList<CancellationTokenSource> svc_cts = new List<CancellationTokenSource> { }; // List of cancellation token sources corresponding to the lookup tasks
            foreach (var service in services)
            {
                svc_cts.Add(new CancellationTokenSource()); // Create cancellation token sources
                svc_tasks.Add(Task.Run(() => { return LookupUID(service.url, service.data, service.xpath, svc_cts.Last().Token); }, cancellationToken: svc_cts.Last().Token)); // Add each lookup task to the pool
            }
            while (svc_tasks.Count > 0)
            {
                Task<long> finished_task = await Task.WhenAny(svc_tasks); // Wait until any task finishes
                if (finished_task.Result >= 0)
                {
                    // Task finishes successfully, cancel all the other tasks and return
                    foreach (var cts in svc_cts) cts.Cancel(); // Send cancellation signal to all tasks (including the one that finished, but that's okay)

                    uid = finished_task.Result;
                    goto retrieved;
                }
            }
            foreach(var service in services)
            {
                // Console.WriteLine(service);
                uid = await LookupUID(service.url, service.data, service.xpath);
                if (uid >= 0) goto retrieved;
            }

            /* Attempt retrieval by scraping Facebook (if possible) */
            string response_data;
            try
            {
                var response = await CommonHTTP.Client.GetAsync($"https://mbasic.facebook.com/{handle}");
                response.EnsureSuccessStatusCode();
                response_data = await response.Content.ReadAsStringAsync();
            }
            catch
            {
                return -2; // Cannot retrieve UID (due to network error)
            }
            var htmldoc = new HtmlDocument();
            htmldoc.LoadHtml(response_data);
            /* In some cases we can get the UID by checking the [Join] button while not logged in */
#nullable enable
            HtmlNode? e = htmldoc.DocumentNode.SelectSingleNode("//a[starts-with(@href, '/r.php')]");
#nullable disable
            if(e != null)
            {
                uid = Convert.ToInt64(Regex.Replace(e.Attributes["href"].Value, "(^.*\\&rid=)|(\\&.*$)", ""));
                goto retrieved;
            }
            if (CommonHTTP.ClientHandler.CookieContainer.Count == 0) return -3; // No cookies to perform logged-in scraping
            /* Check if we are still at the login page */
            if (htmldoc.DocumentNode.SelectSingleNode("//a[starts-with(@href, '/recover')]") != null) return -5; // Password recovery link, only present when we're logging in
            /* Check if we have been ratelimited */
            if (htmldoc.DocumentNode.SelectSingleNode("//a[@href='https://www.facebook.com/help/177066345680802']") != null) return -4;
            /* Retrieve from block link, works for normal profiles */
            e = htmldoc.DocumentNode.SelectSingleNode("//a[starts-with(@href, '/privacy/touch/block/confirm/?bid=')]");
            if(e != null)
            {
                uid = Convert.ToInt64(Regex.Replace(e.Attributes["href"].Value, "(^.*\\?bid=)|(&.*$)", ""));
                goto retrieved;
            }
            /* Retrieve from [More] button link, works for pages */
            e = htmldoc.DocumentNode.SelectSingleNode("//a[starts-with(@href, '/pages/more/')]");
            if(e != null)
            {
                uid = Convert.ToInt64(Regex.Replace(e.Attributes["href"].Value, "\\/.*$", ""));
                goto retrieved;
            }

            return -2; // Cannot retrieve UID

        retrieved:
            AddHandle(handle, uid);
            return uid;
        }

    }
}
