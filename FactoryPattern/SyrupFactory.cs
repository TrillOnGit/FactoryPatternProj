namespace FactoryPattern;

public static class SyrupFactory
{
    public static ISyrup CheckSyrup(string? userIn)
    {
        switch (userIn?.ToLower())
        {
            case "maple" or "maple syrup" or "maplesyrup":
                return new MapleSyrup();
            case "blueberry" or "blueberry syrup" or "blueberrysyrup" or "blue berry syrup":
                return new BlueBerrySyrup();
            default:
                Console.WriteLine("Could not parse input... creating maple syrup.");
                return new MapleSyrup();
        }
    }
}