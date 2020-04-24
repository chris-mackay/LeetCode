using System;

namespace palindrome_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(1221).ToString());
        }

        public static bool IsPalindrome(int x) 
        {
            char[] o = x.ToString().ToCharArray();
            char[] a = x.ToString().ToCharArray();
            Array.Reverse(a);

            if (o.Length == 1) return true;
            if (o.Length != a.Length) return false;

            for (int i = 0; i <= o.Length - 1; i++)
                for (int j = 0; j <= a.Length - 1; j++)
                    if (o[i] != a[i])
                        return false;

            return true;
        }
    }
}
