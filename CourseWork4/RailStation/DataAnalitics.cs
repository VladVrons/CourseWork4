using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailStation
{
    public class DataAnalitics
    {
        public int waitingTime=0;
        public int trains =0;
        public int trainsAtDest= 0;
        public double[] usedRails = new double[7];
        public int[] usageCount = new int[7];
        public void PrintAnalitics()
        {
            Console.WriteLine(trains);
            Console.WriteLine(trainsAtDest);
            Console.WriteLine(usedRails[0]);
            Console.WriteLine(usedRails[1]);
            Console.WriteLine(usedRails[2]);
        }
        public double n()
        {
            return 0.0;
        }
    }
}
