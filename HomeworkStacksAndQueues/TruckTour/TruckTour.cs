//Suppose there is a circle.There are N petrol pumps on that circle.Petrol pumps are numbered 0 to (N−1) (both inclusive). You have two pieces of information corresponding to each of the petrol pump: (1) the amount of petrol that particular petrol pump will give, and (2) the distance from that petrol pump to the next petrol pump.
//Initially, you have a tank of infinite capacity carrying no petrol.You can start the tour at any of the petrol pumps.Calculate the first point from where the truck will be able to complete the circle.Consider that the truck will stop at each of the petrol pumps.The truck will move one kilometer for each liter of the petrol.
//Input Format: The first line will contain the value of N.
//The next N lines will contain a pair of integers each, i.e.the amount of petrol that petrol pump will give and the distance between that petrol pump and the next petrol pump.
//Output Format: An integer which will be the smallest index of the petrol pump from which we can start the tour.
//Constraints: 
//1 ≤ N ≤ 1000001
//1 ≤ amount of petrol, distance ≤ 1000000000


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<GasPump> pumps = new Queue<GasPump>();
            for (int i = 0; i < n; i++)
            {
                string[] pumpInfo = Console.ReadLine().Split();
                int distanceToNext = int.Parse(pumpInfo[1]);
                int amountOfGas = int.Parse(pumpInfo[0]);
                GasPump pump = new GasPump(distanceToNext, amountOfGas, i);
                pumps.Enqueue(pump);
            }
            GasPump starterPump = null;
            bool compeleteJourney = false;
            while (pumps.Count>0)
            {
                GasPump currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                starterPump = currentPump;
                int gasInTank = currentPump.amountOfGas;
                while (gasInTank>= currentPump.distanceToNext)
                {
                    gasInTank -= currentPump.distanceToNext;
                    currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);
                    if (currentPump == starterPump)
                    {
                        compeleteJourney = true;
                        break;
                    }
                    gasInTank += currentPump.amountOfGas;
                }
                if (compeleteJourney)
                {
                    Console.WriteLine(starterPump.indexOfPump);
                    break;
                }
            }
        }
    }
    public class GasPump
    {
        public int distanceToNext;
        public int amountOfGas;
        public int indexOfPump;

        public GasPump(int distanceToNext, int amountOfGas, int indexOfPump)
        {
            this.distanceToNext = distanceToNext;
            this.amountOfGas = amountOfGas;
            this.indexOfPump = indexOfPump;
        }
    } 
}
