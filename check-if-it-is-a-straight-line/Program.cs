using System;
using System.Collections.Generic;
using System.Linq;

namespace checkifitisastraightline
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //[ 1,2],[2,3],[3,4],[4,5],[5,6],[6,7]

            //int[][] p =
            //{
            //    new int[] { 1, 2 },
            //    new int[] { 2, 3 },
            //    new int[] { 3, 4 },
            //    new int[] { 4, 5 },
            //    new int[] { 5, 6 },
            //    new int[] { 6, 7 },

            //};

            //[0,0],[0,1],[0,-1]
            //int[][] p =
            //{
            //    new int[] { 0, 0 },
            //    new int[] { 0, 1 },
            //    new int[] { 0, -1 },
            //};

            //[[2,1],[4,2],[6,3]]
            //int[][] p =
            //{
            //    new int[] { 2, 1 },
            //    new int[] { 4, 2 },
            //    new int[] { 6, 3 },
            //};

            //[[0,0],[0,5],[5,5],[5,0]]
            int[][] p =
            {
                new int[] { 0, 0 },
                new int[] { 0, 5 },
                new int[] { 5, 5 },
                new int[] { 5, 0 },
            };

            //[1,1],[2,2],[2,1],[3,2]
            //int[][] p =
            //{
            //    new int[] { 1, 1 },
            //    new int[] { 2, 2 },
            //    new int[] { 2, 1 },
            //    new int[] { 3, 2 },
            //};

            Console.WriteLine("p makes a line: {0}", CheckStraightLine(p));
        }

        public static bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 1) return false;
            
            List<double> slopes = new List<double>();

            if (IsVerticalOrHorizontalLine(coordinates))
            {
                return true;
            }
            else
            {
                for (int i = 1; i < coordinates.Length; i++)
                {
                    int y1 = coordinates[i-1][1];
                    int y2 = coordinates[i][1];

                    int x1 = coordinates[i-1][0];
                    int x2 = coordinates[i][0];

                    double s = Slope(y2, y1, x2, x1);
                    slopes.Add(s);
                }
            }

            bool allSlopeAreEqual = slopes.All(x => x == slopes.First() && slopes.First() != 0);

            if (allSlopeAreEqual) return true; else return false;
        }

        public static bool IsVerticalOrHorizontalLine(int[][] coordinates)
        {
            List<int> xs = new List<int>();
            List<int> ys = new List<int>();

            for (int i = 0; i < coordinates.Length; i++)
            {
                int x = coordinates[i][0];
                xs.Add(x);

                int y = coordinates[i][1];
                ys.Add(y);
            }

            bool IsVertical = xs.All(x => x == xs.First());
            bool IsHorizontal = ys.All(y => y == ys.First());

            if (IsHorizontal || IsVertical) return true; else return false;
        }

        public static double Slope(int y2, int y1, int x2, int x1)
        {
            if ((x2 - x1) == 0) return 0;
            double m = ((double)y2 - (double)y1) / ((double)x2 - (double)x1);

            return m;
        }
    }
}
