

namespace Logicalprogram
{
    internal class PrimeNumber
    {
        public static void PrimeNo()
        {
            Console.WriteLine("enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i = 2; i < (n - 1); i++)
            {
                if (n % i == 0)
                {
                    temp = temp + 1;
                }
            }
            if (temp == 0)
            {
                Console.WriteLine(n + " is a prime number");
            }
            else
            {
                Console.WriteLine(n + " is not a prime number");
            }
        }
    }
}
