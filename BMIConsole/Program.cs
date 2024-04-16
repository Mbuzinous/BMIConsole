namespace BMIConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BMICalculator.BMICalculator calc = new BMICalculator.BMICalculator();

            Console.WriteLine(calc.Calculate(80.0, 180));
            Console.ReadKey();
        }
    }
}
