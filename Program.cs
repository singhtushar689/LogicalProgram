using System.Globalization;

namespace LogicalProgram
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(number + " is not Prime");
                    return;
                }
            }
            {
                Console.WriteLine(number + " is a Prime");
            }
        }
    }
}