
using RailStation;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");
        TrainManager trainManager = new TrainManager();
        trainManager.Seed2();
        trainManager.Update();
        trainManager.FinishProcess();
        Console.WriteLine("finish");
    }
}