using System.Runtime.InteropServices.Marshalling;

namespace FactorialRecursion 
{
    class Program 
    {
         static int Factorial(int num, int ans)
        {
            if (num == 0)
            {
                return 1;
            }
            else if (num == 1)
            {
                return ans;
            }
            else
            {
                num -= 1;
                ans *= num;
                return Factorial(num, ans);
            }
        }

        static void Main(string[] args)
        {
            int num;
            int ans;


            Console.WriteLine("Welcome to the factorial calculator!");

            while (true)
            {
                Console.WriteLine("Enter a number you would like to calculate: ");
                Console.Write("$> ");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid input.\nPlease try again.\n");
                    continue;
                }

                if (num < 0) 
                {
                    Console.WriteLine("Number must not be negtive.\nPlease try again.\n");
                    continue;
                }
                break;
            }

            ans = num;
            int answer = Factorial(num, ans);

            Console.WriteLine("The answer to " + num + "! is " + answer);
        } 


        
    }
}
