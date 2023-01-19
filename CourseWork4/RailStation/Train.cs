using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailStation
{
    public class Train : TrainManager
    {
        public City Destination;

        public Train(City d)
        {
            Destination = d;
        }
    }
}
