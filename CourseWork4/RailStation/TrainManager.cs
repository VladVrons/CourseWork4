using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailStation
{
    public class TrainManager : DataAnalitics
    {
        DataAnalitics dataAn = new DataAnalitics();
        double time = 0;
        private List<City> cityList = new List<City>();
        private List<Railway> railsList = new List<Railway>();
        public void Seed()
        {
            City city1 = new City("city1");
            City city2 = new City("city2");
            City city3 = new City("city3");
            Railway railway1 = new Railway(city1, city2, 4);
            Railway railway2 = new Railway(city1, city3, 4);
            Railway railway3 = new Railway(city2, city3, 4);
            city1.AddRail(railway1);
            city1.AddRail(railway2);
            city2.AddRail(railway1);
            city2.AddRail(railway3);
            city3.AddRail(railway2);
            city3.AddRail(railway3);
            cityList.Add(city1);
            cityList.Add(city2);
            cityList.Add(city3);
            railsList.Add(railway1);
            railsList.Add(railway2);
            railsList.Add(railway3);

        }

        public void Seed2()
        {
            City city1 = new City("city1");
            City city2 = new City("city2");
            City city3 = new City("city3");
            Railway railway1 = new Railway(city1, city2, 4);
            Railway railway2 = new Railway(city1, city3, 4);
            Railway railway3 = new Railway(city2, city3, 4);
            Railway railway12 = new Railway(city1, city2, 4);
            Railway railway22 = new Railway(city1, city3, 4);
            Railway railway32 = new Railway(city2, city3, 4);
            city1.AddRail(railway1);
            city1.AddRail(railway2);
            city2.AddRail(railway1);
            city2.AddRail(railway3);
            city3.AddRail(railway2);
            city3.AddRail(railway3);
            city1.AddRail(railway12);
            city1.AddRail(railway22);
            city2.AddRail(railway12);
            city2.AddRail(railway32);
            city3.AddRail(railway22);
            city3.AddRail(railway32);
            cityList.Add(city1);
            cityList.Add(city2);
            cityList.Add(city3);
            railsList.Add(railway1);
            railsList.Add(railway2);
            railsList.Add(railway3);
            railsList.Add(railway12);
            railsList.Add(railway22);
            railsList.Add(railway32);

        }


        public void FinishProcess()
        {
            for (int i = 0; i < dataAn.usageCount.Length; i++)
            {
                dataAn.usedRails[i] = dataAn.usageCount[i] / time;
            }
            dataAn.PrintAnalitics();
        }

        public void Update()
        {

            while (time < 150)
            {
                time += 1;
                Console.WriteLine("Day" + time.ToString());
                foreach (City city in cityList)
                {
                    dataAn.trains = dataAn.trains + city.GenerateTrains();

                    if (city.trains.Count > 0)
                    {
                        //for(int i=0; i<city.trains.Count; i++)
                        //{
                        var city2 = city.trains.Peek().Destination;
                        //var city2 = city.trains.re
                        //city.trains.
                        foreach (Railway rail in city.rails)
                        {

                            if ((rail.pointB.Name == city2.Name) && (rail.pointB.Name == city2.Name))
                            {
                                if (rail.isAvailable && city.trains.Count > 0)
                                {
                                    rail.isAvailable = false;
                                    Console.WriteLine("train goes to " + city.trains.Dequeue().Destination.Name+" rail "+rail);
                                }

                            }

                        }
                        //}
                    }
                }
                foreach (Railway rail in railsList)
                {
                    if (rail.isAvailable)
                    {
                        //dataAn.usedRails[railsList.IndexOf(rail)] = dataAn.usedRails*
                        dataAn.usageCount[railsList.IndexOf(rail)]++;
                    }
                    if (rail.WayProcess())
                    {
                        Console.WriteLine("trainAtDest");
                        dataAn.trainsAtDest++;
                    }
                }
            }
        }


    }

}
