namespace LogicalProgram
{
     class Program
    {
        public static void FibSeries(int terms)
        {
            int a=0 , b=1 , c = 0;
            if (terms == 0)
            {
                Console.WriteLine(a);
            }
            for (int i =1; i <= terms ; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b + " ");
            }
        }
          public static void Main(string[] args)
          { 
            Console.WriteLine("Enter the number of terms in Fibonacci Series");
            int terms = Convert.ToInt32(Console.ReadLine());
            FibSeries(terms);
          }
    }
}