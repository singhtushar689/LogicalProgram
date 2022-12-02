using System.Globalization;

namespace LogicalProgram
{
    class Program
    {
<<<<<<< HEAD
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
=======
        public static void Main(string[] args) 
         {
             Console.WriteLine("Welcome to Logica Programs");
             Console.WriteLine("Enter num of coupon ");
             int num = Convert.ToInt32(Console.ReadLine());
             //create an array and Initializing all the values to false
             bool[] couponNumArray = new bool[num];
             int countRandom = 0;
             int i = 0;

            while (i<num)
            {
                Random random = new Random();
                int couponNum = random.Next(0, num);
                countRandom++;
                if(couponNumArray[couponNum] == false)
                {
                    couponNumArray[couponNum] = true;
                    i++;
                }

                Console.Write(countRandom + " times random coupons are generates to get unique coupon number");
>>>>>>> CouponNumber
            }
            Console.WriteLine("Reverse number is " + reverse);        
        }
    }
}