/*
 * Progress.cs - A quick and dirty progress indicator bar.
 * Created on: 18:30 20-01-2022
 * Author    : itsmevjnk
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace FrontendRef
{
    public class Progress: IDisposable
    {
        /// <summary>
        ///  The progress bar's total length.
        /// </summary>
        public int Size { get; }

        /// <summary>
        ///  The length of the bar's elapsed portion.
        /// </summary>
        private int LastLength = 0;

        /// <summary>
        ///  The percentage shown next to the progress bar.
        /// </summary>
        private int LastPercent = 0;

        /// <summary>
        ///  The X coordinate where the progress bar is drawn. The X coordinates for each element in the progress bar can be derived from this: Progress bar start      : StartX + 1                = StartX        + 1 Progress bar end        : StartX + 1 + Size         = StartX + Size + 1 Percentage portion start: StartX + 1 + Size + 2     = StartX + Size + 3 Update indicator        : StartX + 1 + Size + 2 + 5 = StartX + Size + 8
        /// </summary>
        private int StartX;

        /// <summary>
        ///  Indicates which character from the 4 characters |/-\ to be drawn for indicating progress update.
        /// </summary>
        private int UpdateIndicator = 0;

        /// <summary>
        ///  Class constructor. Draws the frame for the progress bar.
        /// </summary>
        /// <param name="size">The progress bar's length in characters (optional). Defaults to 20.</param>
        public Progress(int size = 20)
        {
            Size = size; StartX = Console.CursorLeft;
            Console.Write('['); // Opening bracket for indication bar
            for (int i = 0; i < size; i++) Console.Write('.');
            Console.Write("]    %"); // Closing bracket for indication bar and percentage placeholder
        }

        /// <summary>
        ///  Updates the progress bar.
        /// </summary>
        /// <param name="percent">The current percentage.</param>
        /// <returns>true.</returns>
        public bool Update(float percent)
        {
            /* Update progress indicator */
            int len = (int) ((percent / 100) * Size);
            if (len != LastLength)
            {
                /* We need to update it */
                if (len < LastLength)
                {
                    /* Decreased, so we need to draw more dots */
                    Console.SetCursorPosition(StartX + 1 + len, Console.CursorTop);
                    Console.Write(new String('.', LastLength - len));
                }
                else
                {
                    /* Increased, so we need to draw more # characters */
                    Console.SetCursorPosition(StartX + 1 + LastLength, Console.CursorTop);
                    Console.Write(new String('#', len - LastLength));
                }
                LastLength = len;
            }

            /* Update percentage */
            if (LastPercent != (int)percent)
            {
                LastPercent = (int)percent;
                Console.SetCursorPosition(StartX + Size + 3, Console.CursorTop);
                Console.Write(Convert.ToString(LastPercent).PadLeft(3));
            }

            /* Change the update indicator so user knows the operation is still alive */
            Console.SetCursorPosition(StartX + Size + 8, Console.CursorTop);
            Console.Write(@"|/-\"[UpdateIndicator]);
            UpdateIndicator = (UpdateIndicator + 1) % 4;

            return true;
        }

        /// <summary>
        ///  Clear out the progress bar.
        /// </summary>
        public void Dispose()
        {
            Console.SetCursorPosition(StartX, Console.CursorTop);
            Console.Write(new String(' ', Size + 9));
            Console.SetCursorPosition(StartX, Console.CursorTop);
        }
    }
}
