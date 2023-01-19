using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailStation
{
    public class City : TrainManager
    {
        public string Name { get; set; }
        public Queue<Train> trains;
        public List<Railway> rails;

        public City(string name)
        {
            Name = name;
            trains = new Queue<Train>();
            rails = new List<Railway>();
        }

        public int GenerateTrains()
        {
            var rand = new Random();

            if (rand.NextDouble() < 0.25)
            {
                var cr = rails.ElementAt(rand.Next(0, rails.Count));
                if (cr.pointB != this)
                {
                    trains.Enqueue(new Train(cr.pointB));
                }
                else { trains.Enqueue(new Train(cr.pointA)); }
                Console.WriteLine("Train created in " + Name);
                return 1;
            }
            return 0;
        }

        public void AddRail(Railway railway)
        {
            rails.Add(railway);
        }


    }
}
