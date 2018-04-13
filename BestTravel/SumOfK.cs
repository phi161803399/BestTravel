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
            int i = 0;
            do
            {
                tripDistances[0] = distances[i];
                Console.WriteLine("First distance: " + tripDistances[0]);
                RemoveDistance(distances,i);
                numberOfTowns--;
                for (int j=0;j<= distances.Count - numberOfTowns;j++)
                {
                    Console.WriteLine($"Second distance: {distances[j]}");
                }                
                i++;
            } while (i <= numberOfLoops); //numberOfLoops
        }

        static List<int> RemoveDistance(List<int> ls,int i)
        {
            for (int k = 0;k<=i;k++)
            {
                ls.Remove(ls[i]);
            }            
            return ls;
        }

    }
}
