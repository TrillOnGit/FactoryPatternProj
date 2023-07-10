namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Take user input
            Console.WriteLine("What would you like to put into our syrup machine? Maple or Blueberries?");
            var userIn = Console.ReadLine();
            Console.WriteLine("How many jars would you like to create?");
            var userNum = int.Parse(Console.ReadLine() ?? string.Empty) ;
            //Check with method and create with method
            ISyrup syrup = SyrupFactory.CheckSyrup(userIn);
            syrup.Create(userNum);
        }
    }
}
