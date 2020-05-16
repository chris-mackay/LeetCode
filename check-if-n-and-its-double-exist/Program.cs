using System;

namespace checkifnanditsdoubleexist
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = { 10, 2, 5, 3 };
            Console.WriteLine(CheckIfExist(a));
        }

        public static bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i <= arr.Length - 1; i++)
                for (int j = 0; j <= arr.Length - 1; j++)
                {
                    if (i >= 0)
                        if (i != j)
                            if (arr[i] == 2 * arr[j])
                                return true;
                }
            return false;
        }

    }
}
