using System;
using System.Text;

namespace kconcatenationmaximumsum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, -2, 1 };
            int k = 5;
            Console.WriteLine(KConcatenationMaxSum(a,k).ToString());
            Console.ReadLine();
        }

        public static int KConcatenationMaxSum(int[] arr, int k)
        {
            if (arr.Length == 0) return 0;
            int r = 0;

            for (int i = 0; i <= k; i++)
                foreach (int s in arr)
                    r += Convert.ToInt32(s.ToString());
           
            return r;
        }

    }
}
