namespace Logicalprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welecome to fibonaci series ");
            Console.WriteLine("chooes program\n1. fibonaci series\n2.find perfect number\n3.find prime number or not\n4.reverse a number \n5.coupon number \n6.stop watch program");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Fibonaciseries.FibSeries();
                    break;
                case 2:
                    PerfectNumber.perfectno();
                    break;
                case 3:
                    PrimeNumber.PrimeNo();
                    break;
                case 4:
                    ReverseNumber.ReverseNo();
                    break;
                case 5:
                    CouponNumbers.coupon();
                    break;
                case 6:
                    StopwatchProgram.Stopwatch();
                    break;
                default : Console.WriteLine("wrong choice");
                    break;

            }
        }
    }
}