/*
 * FBReact.cs - Class for storing information on a person's reaction
 *              to a Facebook post.
 * Created on: 21:45 30-12-2021
 * Author    : itsmevjnk
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace HRngBackend
{
    /*
     * public enum ReactionEnum
     *   Enumeration for storing reaction type.
     */
    public enum ReactionEnum
    {
        None = -1,
        Like = 1,
        Love,
        Wow,
        Haha,
        Sad = 7,
        Angry,
        Thankful = 11,
        Pride,
        Care = 16
    }

    public class FBReact
    {
        /*
         * public long UserID
         *   The user's ID.
         */
        public long UserID = -1;

        /*
         * public string UserName
         *   The user's name (optional).
         */
        public string UserName = "";
        
        /*
         * public ReactionEnum Reaction
         *   The user's reaction.
         */
        public ReactionEnum Reaction = ReactionEnum.None;
    }
}
