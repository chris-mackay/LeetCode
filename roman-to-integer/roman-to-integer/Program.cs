using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman_to_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("DCXXI").ToString());
            Console.ReadLine();
        }

        public static int RomanToInt(string s)
        {
            int result = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            char[] a = s.ToCharArray();

            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (i + 1 < a.Length)
                {
                    if (a[i] == 'I' && (a[i + 1] == 'V' || a[i + 1] == 'X'))
                    {
                        result += dict[a[i + 1]] - dict[a[i]];
                        a[i] = '\0';
                        a[i + 1] = '\0';
                    }
                    else if (a[i] == 'X' && (a[i + 1] == 'L' || a[i + 1] == 'C'))
                    {
                        result += dict[a[i + 1]] - dict[a[i]];
                        a[i] = '\0';
                        a[i + 1] = '\0';
                    }
                    else if (a[i] == 'C' && (a[i + 1] == 'D' || a[i + 1] == 'M'))
                    {
                        result += dict[a[i + 1]] - dict[a[i]];
                        a[i] = '\0';
                        a[i + 1] = '\0';
                    }
                    else
                        if (a[i] != '\0')
                            result += dict[a[i]];
                }
                else
                    if (a[i] != '\0')
                        result += dict[a[i]];
            }

            return result;
        }
    }
}
