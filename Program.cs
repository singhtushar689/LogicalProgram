using System.Globalization;

namespace LogicalProgram
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while(number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse *10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse number is " + reverse);        
        }
    }
}