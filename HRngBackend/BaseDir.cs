/*
 * BaseDir.cs - Class for defining base directories' locations.
 * Created on: 11:00 25-12-2021
 * Author    : itsmevjnk
 */

using System.IO;
using System.Reflection;

namespace HRngBackend
{
    public static class BaseDir
    {
        /*
         * public static string CommonBase
         *   The base directory where common data (e.g. config
         *   files) is stored.
         */
        public static string CommonBase = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        /*
         * public static string PlatformBase
         *   The base directory where platform-specific data
         *   (e.g. browser or driver) is stored.
         */
        public static string PlatformBase = Path.Combine(CommonBase, OSCombo.Combo);
    }
}
