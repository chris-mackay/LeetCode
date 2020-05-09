using System;

namespace boatstosavepeople
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] people = { 3, 8, 7, 1, 4 };
            int limit = 9;

            Console.WriteLine(NumRescueBoats(people, limit).ToString());
        }

        public static int NumRescueBoats(int[] people, int limit)
        {
            int boats = 1;
            int weightInBoat = 0;

            for (int i = 0; i <= people.Length - 1; i++)
            {
                int w = people[i];
                weightInBoat += w;

                if (weightInBoat > limit)
                {
                    weightInBoat = w;
                    boats++;
                }
                else if (weightInBoat == limit && i < people.Length - 1)
                {
                    boats++;
                    weightInBoat = 0;
                }
            }
            return boats;
        }

    }
}
