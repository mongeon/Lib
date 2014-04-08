using System;

namespace Mongeon.Lib.Strings
{
    public static class Extensions
    {
        /// <summary>
        /// Pad the string with space and will be centered.
        /// </summary>
        /// <param name="s">String to be centered</param>
        /// <param name="totalWidth">Total length of the resulting string, including space</param>
        /// <returns>The padded string</returns>
        public static string PadCenter(this string s, int totalWidth)
        {
            return PadCenter(s, totalWidth, ' ');
        }

        /// <summary>
        /// Pad the string with a character and will be centered.
        /// </summary>
        /// <param name="s">String to be centered</param>
        /// <param name="totalWidth">Total length of the resulting string, including padding</param>
        /// <param name="paddingCharacter">The character used to pad the string</param>
        /// <returns>The padded string</returns>
        public static string PadCenter(this string s, int totalWidth, char paddingCharacter)
        {
            if (s == null)
            {
                throw new ArgumentNullException("s");
            }
            if (s.Length > totalWidth)
            {
                throw new InvalidOperationException();
            }
            int halfSpace = (totalWidth - s.Length) / 2;
            return s.PadRight(halfSpace + s.Length, paddingCharacter).PadLeft(totalWidth, paddingCharacter);
        }
    }
}