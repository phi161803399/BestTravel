using System;
using System.Collections.Generic;
using System.Text;

namespace BestTravel
{
    public static class SumOfK
    {
        static List<int> distances = new List<int> { 50, 55, 57, 58, 60 };

        public static void chooseBestSum(int k)
        {
            int numberOfTowns = k;
            int numberOfLoops = distances.Count - numberOfTowns;
            int[] tripDistances = new int[numberOfTowns];
            for (int i = 0; i <= numberOfLoops; i++)
            {
                tripDistances[0] = distances[i];
                Console.WriteLine("First distance: " + tripDistances[0]);
                //numberOfTowns--;
                //Console.WriteLine("Towns: " + numberOfTowns);
                for (int j = i + 1; j <= numberOfLoops; j++)
                {
                    tripDistances[0] = distances[j];
                    Console.WriteLine("Second distance: " + tripDistances[0]); 
                }
            }
        }
    }
}
