namespace LogicalProgram
{
    class Program
    {
        public static void Main()
        {
            int sum = 0;
            Console.WriteLine("Enter the Number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number  + "is a perfect Number");
            }
            else
            {
                Console.WriteLine(number +  " is not a perfect Number");
            }
        } 
    }             
}