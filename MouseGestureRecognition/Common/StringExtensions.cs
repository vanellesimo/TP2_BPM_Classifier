using System;

namespace MouseGestureRecognition.Common
{
    public static class StringExtensions
    {
        public static bool IsNone(this string value)
        {
            return value.ToLower().Equals("none", StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsValid(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}
