using System.Threading;
namespace FactoryPattern;

public class BlueBerrySyrup : ISyrup
{
    public void Create(int reps)
    {
        for (int i = 0; i < reps; i++)
        {
            Console.WriteLine("Squashing blueberries....");
            Thread.Sleep(1000);
            Console.WriteLine($"Done. Created {i + 1} jar of blueberry syrup.");
            Thread.Sleep(50);
        }
    }
}