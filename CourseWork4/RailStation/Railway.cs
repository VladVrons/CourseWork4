namespace RailStation
{
    public class Railway : TrainManager
    {
        public bool isAvailable = true;
        public City pointA;
        public City pointB;
        public int WayDuration;
        public Railway(City a, City b, int t)
        {

            pointA = a;
            pointB = b;
            WayDuration = t;
        }


        public bool WayProcess()
        {
            if (!isAvailable)
            {
                if (WayDuration == 0)
                {
                    WayDuration = 4;
                    isAvailable = true;
                    return true;
                }
                else
                {
                    WayDuration -= 1;
                    return false;
                }
            }
            return false;
        }
    }
}