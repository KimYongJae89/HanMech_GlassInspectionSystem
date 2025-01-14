﻿using System;

namespace HMechUtility.ProgressBarUtility
{
    internal static class NativeMethods
    {
        

        #region Parameters

        /* Sent when the system makes a request to paint (a portion of) a window. */
        public const int WM_PAINT = 0xf;

        /* Sent to a window to request that it draw its client area in the 
        specified device context, most commonly in a printer device context. */
        public const int WM_PRINTCLIENT = 0x318;

        /* Paints all descendants of a window in bottom-to-top painting order using double-buffering. */
        public const int WS_EX_COMPOSITED = 0x2000000;

        #endregion


        #region Structures

        /* Contains information to be used to paint the client area of a window. */
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public struct PAINTSTRUCT
        {
            /* A handle to the display DC to use for painting. */
            public IntPtr hdc;

            /* Indicates whether the background should be erased. */
            public bool fErase;

            /* A RECT structure that specifies the upper left and lower right 
            corners of the rectangle in which the painting is requested, */
            public RECT rcPaint;

            /* Reserved; used internally by the system. */
            public bool fRestore;

            /* Reserved; used internally by the system. */
            public bool fIncUpdate;            
        }
        
        /* Defines the coordinates of the upper-left and lower-right corners of a rectangle. */
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public struct RECT
        {
            /* The x-coordinate of the upper-left corner of the rectangle. */
            public int Left;
            
            /* The y-coordinate of the upper-left corner of the rectangle. */
            public int Top;
            
            /* The x-coordinate of the lower-right corner of the rectangle. */
            public int Right;
            
            /* The y-coordinate of the lower-right corner of the rectangle. */
            public int Bottom;
        }

        /*  Contains basic information about a physical font. This is the Unicode version of the structure. */
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        public struct TEXTMETRIC
        {
            /* The height (ascent + descent) of characters. */
            public int tmHeight;

            /* The ascent (units above the base line) of characters. */
            public int tmAscent;

            /* The descent (units below the base line) of characters. */
            public int tmDescent;

            /* The amount of leading (space) inside the bounds set by the tmHeight member. */
            public int tmInternalLeading;

            /* The amount of extra leading (space) that the application adds between rows. */
            public int tmExternalLeading;

            /* The average width of characters in the font (generally defined as the width of the letter x). */
            public int tmAveCharWidth;

            /* The width of the widest character in the font. */
            public int tmMaxCharWidth;

            /* The weight of the font. */
            public int tmWeight;

            /* The extra width per string that may be added to some synthesized fonts. */
            public int tmOverhang;

            /* The horizontal aspect of the device for which the font was designed. */
            public int tmDigitizedAspectX;

            /* The vertical aspect of the device for which the font was designed. */
            public int tmDigitizedAspectY;

            /* The value of the first character defined in the font. */
            public char tmFirstChar;

            /* The value of the last character defined in the font. */
            public char tmLastChar;

            /* The value of the character to be substituted for characters not in the font. */
            public char tmDefaultChar;

            /* The value of the character that will be used to define word breaks for text justification. */
            public char tmBreakChar;

            /* Specifies an italic font if it is nonzero. */
            public byte tmItalic;

            /* Specifies an underlined font if it is nonzero. */
            public byte tmUnderlined;

            /* A strikeout font if it is nonzero. */
            public byte tmStruckOut;

            /* Specifies information about the pitch, the technology, and the family of a physical font. */
            public byte tmPitchAndFamily;

            /* The character set of the font. */
            public byte tmCharSet;
        }

        /* Contains basic information about a physical font. This is the ANSI version of the structure. */
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = System.Runtime.InteropServices.CharSet.Ansi)]
        public struct TEXTMETRICA
        {
            /* The height (ascent + descent) of characters. */
            public int tmHeight;

            /* The ascent (units above the base line) of characters. */
            public int tmAscent;

            /* The descent (units below the base line) of characters. */
            public int tmDescent;

            /* The amount of leading (space) inside the bounds set by the tmHeight member. */
            public int tmInternalLeading;

            /* The amount of extra leading (space) that the application adds between rows. */
            public int tmExternalLeading;

            /* The average width of characters in the font (generally defined as the width of the letter x). */
            public int tmAveCharWidth;

            /* The width of the widest character in the font. */
            public int tmMaxCharWidth;

            /* The weight of the font. */
            public int tmWeight;

            /* The extra width per string that may be added to some synthesized fonts. */
            public int tmOverhang;

            /* The horizontal aspect of the device for which the font was designed. */
            public int tmDigitizedAspectX;

            /* The vertical aspect of the device for which the font was designed. */
            public int tmDigitizedAspectY;

            /* The value of the first character defined in the font. */
            public byte tmFirstChar;

            /* The value of the last character defined in the font. */
            public byte tmLastChar;

            /* The value of the character to be substituted for characters not in the font. */
            public byte tmDefaultChar;

            /* The value of the character that will be used to define word breaks for text justification. */
            public byte tmBreakChar;

            /* Specifies an italic font if it is nonzero. */
            public byte tmItalic;

            /* Specifies an underlined font if it is nonzero. */
            public byte tmUnderlined;

            /* A strikeout font if it is nonzero. */
            public byte tmStruckOut;

            /* Specifies information about the pitch, the technology, and the family of a physical font. */
            public byte tmPitchAndFamily;

            /* The character set of the font. */
            public byte tmCharSet;
        }

        #endregion


    }
}
