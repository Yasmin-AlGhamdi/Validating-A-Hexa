using System;

namespace ValidatingAHexa
{
    class Program
    {
        public static bool isValid(string hexa)
        {
            if (hexa.Length != 7)
                return false;
            if (hexa[0] != '#')
                return false;

            var testChars = hexa.Substring(1).ToLower().ToCharArray();

            foreach (var ch in testChars)
            {
                if (Char.IsDigit(ch))
                    continue;
                if (ch < 'a' || ch > 'f')
                {
                    return false;
                }
            }
            return true;
            // Regular Expressions: return Regex.IsMatch(hexa, @"[#][0-9A-Fa-f](6)");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(isValid("#C15EF9"));
            Console.WriteLine(isValid("9D555"));

            Console.ReadKey();
        }
    }
}
