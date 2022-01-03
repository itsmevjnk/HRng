/*
 * Entry.cs - Class for containing information on entries
 *            (e.g. a person whose interactions with a Facebook
 *            post are to be checked)
 * Created on: 16:32 02-01-2022
 * Author    : itsmevjnk
 */

using System.Collections.Generic;

namespace HRngBackend
{
    public class Entry
    {
        /*
         * public IList<long> UID
         *   List of UIDs associated with the entry.
         */
        public IList<long> UID = new List<long>();

        /*
         * public IDictionary<int, string> Data
         *   Other data (other than the UIDs) associated with
         *   the entry. The key is the column number starting
         *   from 0 where the data was taken from and will be
         *   written to.
         */
        public IDictionary<int, string> Data = new Dictionary<int, string>();

        /*
         * public IDictionary<int, int> IntData
         *   Integer copy of data entries above (if available).
         *   Only used for calculation purposes.
         */
        public IDictionary<int, int> IntData = new Dictionary<int, int>();
    }
}
