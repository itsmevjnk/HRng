/*
 * FBComment.cs - Class for storing information on a Facebook comment.
 * Created on: 16:40 29-12-2021
 * Author    : itsmevjnk
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace HRngBackend
{
    public class FBComment
    {
        /*
         * public long ID
         *   The comment's ID.
         */
        public long ID = -1;

        /*
         * public long Parent
         *   The ID of the comment's parent (optional).
         *   The default value of -1 indicates that this comment has
         *   no parents.
         */
        public long Parent = -1;

        /*
         * public long AuthorID
         *   The user ID of the comment's author.
         */
        public long AuthorID = -1;

        /*
         * public string AuthorName
         *   The comment author's name (optional).
         */
        public string AuthorName = "";

        /*
         * public string CommentText
         *   The comment's text, stripped of all HTML tags.
         *   Can be left blank if there's no text in the comment.
         */
        public string CommentText = "";

        /*
         * public string CommentText_HTML
         *   HTML code of the comment's text portion (optional).
         */
        public string CommentText_HTML = "";

        /*
         * public IList<long> Mentions
         *   List containing UIDs of accounts mentioned in the comment.
         */
        public IList<long> Mentions = new List<long>();

        /*
         * public string EmbedTitle
         *   Title of the embed section underneath the comment's
         *   text (usually for external links).
         *   Can be left blank if there's none.
         */
        public string EmbedTitle = "";

        /*
         * public string EmbedURL
         *   URL of the embed section underneath the comment's text
         *   (usually for external links).
         *   Can be left blank if there's none.
         */
        public string EmbedURL = "";

        /*
         * public string ImageURL
         *   URL of the attached image.
         *   Can be left blank if there's none.
         */
        public string ImageURL = "";

        /*
         * public string VideoURL
         *   URL of the attached video.
         *   Can be left blank if there's none.
         */
        public string VideoURL = "";

        /*
         * public string StickerURL
         *   URL of the attached sticker.
         *   Can be left blank if there's none.
         */
        public string StickerURL = "";
    }
}
