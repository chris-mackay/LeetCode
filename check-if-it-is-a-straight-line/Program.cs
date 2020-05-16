using System;

namespace checkifitisastraightline
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //[ 1,2],[2,3],[3,4],[4,5],[5,6],[6,7]
            int[][] p =
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 5, 6 },
                new int[] { 6, 7 },

            };

            Console.WriteLine("p makes a line: {0}", CheckStraightLine(p));
        }

        public static bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length == 2) return true;
                  
            int x2 = coordinates[1][0];
            int y2 = coordinates[1][1];

            int x3 = coordinates[2][0];

            int y3 = Slope(coordinates)*(x3 - x2) + y2;

            if (y3 == coordinates[2][1]) return true; else return false;
        }

        public static int Slope(int[][] p)
        {
            int x1 = p[0][0];
            int x2 = p[1][0];

            int y1 = p[0][1];
            int y2 = p[1][1];

            return (y2-y1) / (x2-x1);
        }
    }
}
