class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the first number: ");
            string firstNum = Console.ReadLine();
            int.TryParse(firstNum, out int firstNumParse);

            Console.WriteLine("Enter the second number: ");
            string secondNum = Console.ReadLine();
            int.TryParse(secondNum, out int secondNumParse);

            int result = firstNumParse / secondNumParse;
            Console.WriteLine($"Result: {result}"); 
            
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("An exception occurred!");
        }
    }
}