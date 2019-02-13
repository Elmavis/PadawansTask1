using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0 || currentPopulation <= 0)
                throw new ArgumentException();
            double value = initialPopulation;
            int yearsNum = 0;
            for (yearsNum = 0; value <= currentPopulation; yearsNum++)
            {
                value += value * percent * 0.01;
                value += visitors;
            }
            return yearsNum;
        }
    }
}