namespace FactoryPattern;

public class MapleSyrup : ISyrup
{
    public void Create(int reps)
    {
        for (int i = 0; i < reps; i++)
        {
            Console.WriteLine("Squashing Maple Syrup...");
            Thread.Sleep(1000);
            Console.WriteLine($"Done. Created {i + 1} jar of maple syrup.");
            Thread.Sleep(50);
        }
    }
}