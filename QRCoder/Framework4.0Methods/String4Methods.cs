using System;

namespace QRCoder
{
    internal static class String40Methods
    {
        /// <summary>
        /// Indicates whether the specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <returns>
        ///   <see langword="true"/> if the <paramref name="value"/> is null, empty, or white space; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool IsNullOrWhiteSpace(String value)
        {
#if NET35
            if (value == null) return true;

            for (int i = 0; i < value.Length; i++)
            {
                if (!Char.IsWhiteSpace(value[i])) return false;
            }

            return true;
#else
            return string.IsNullOrWhiteSpace(value);
#endif
        }
    }
}