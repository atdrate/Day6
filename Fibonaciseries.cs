

namespace Logicalprogram
{
    internal class Fibonaciseries
    {
        
        
            public static void FibSeries()
            {
                int a = 0, b = 1;


                Console.WriteLine("enter the number for limit of series");
                int n = Convert.ToInt32(Console.ReadLine());
                int c;
                for (int i = 1; i < n; i++)
                {
                    c = a + b;
                    Console.WriteLine(+c);
                    a = b;
                    b = c;


                }


            }

        }
    }
