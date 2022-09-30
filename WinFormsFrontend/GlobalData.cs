using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HRngBackend;
using HRngLite;
using HRngSelenium;
using OpenQA.Selenium;

namespace WinFormsFrontend
{
    internal static class GlobalData
    {
        public static IBrowserHelper Browser = null;
        public static IWebDriver SeDriver = null;

        public static bool FBLoggedIn = false;

        public static EntryCollection EC = null;

        public static Spreadsheet Sheet = null;
    }
}
