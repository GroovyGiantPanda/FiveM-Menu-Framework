using System;
using System.Text;

namespace MenuFramework
{
    public static class StringExtensions
    {
        /// <summary>
        /// Changes e.g. BANANA to Banana 
        /// useful for e.g. vehicle model names which are returned in caps
        /// from default native
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToTitleCase(this string str)
        {
            var tokens = str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < tokens.Length; i++)
            {
                var token = tokens[i];
                tokens[i] = token.Substring(0, 1).ToUpper() + token.Substring(1).ToLower();
            }

            return string.Join(" ", tokens);
        }

        /// <summary>
        /// Turns e.g. "StunGun" into "Stun Gun"
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string AddSpacesToCamelCase(this string source)
        {
            StringBuilder builder = new StringBuilder();
            foreach (char c in source)
            {
                if (Char.IsUpper(c) && builder.Length > 0) builder.Append(' ');
                builder.Append(c);
            }
            return builder.ToString();
        }

        public static string RemoveSpaces(this string source)
        {
            return source.Replace(" ", "");
        }

        /// <summary>
        /// Returns same string but with first letter changed to uppercase.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string FirstLetterToUpper(this string source)
        {
            if (source == null)
                return null;

            if (source.Length > 1)
                return char.ToUpper(source[0]) + source.Substring(1);

            return source.ToUpper();
        }
    }
}