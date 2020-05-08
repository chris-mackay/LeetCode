using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boats_to_save_people
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] people = { 3,2,2,1 };
            int limit = 3;

            Console.WriteLine(NumRescueBoats(people, limit).ToString());
            Console.Read();

        }

        public static int NumRescueBoats(int[] people, int limit)
        {
            int weightInBoat = people[0];
            int boats = 1;

            for (int i = 1; i <= people.Length - 1; i++)
            {
                weightInBoat += people[i];
                
                if (weightInBoat >= limit)
                {
                    boats++;
                    weightInBoat = 0;
                }
            }

            return boats;
        }
    }
}
