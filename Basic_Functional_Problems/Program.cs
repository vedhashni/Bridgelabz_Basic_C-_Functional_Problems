using System;

namespace Basic_Functional_Problems
{
    /// <summary>
    /// UC1 - To find the percentage of head VS tail
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic C# and functional problems!");

            while (true)
            {
                // '1' - is used to find the percentage of head VS tail
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter number of times to filp a coin");
                        int flip = Convert.ToInt32(Console.ReadLine());
                        Program.FlipCoins(flip);
                        break;

                    case 2:
                        return;

                    default:
                        break;

                }
            }
        }
        // Fuction to find percentage of head and tail
        public static void FlipCoins(int flip)
        {
            int t = 0, h = 0;
            Random random = new Random();
            for(int i = 0; i < flip; i++)
            {
                double randomMove = random.NextDouble();
                if(randomMove<0.5)
                {
                    t++;
                }
                else
                {
                    h++;
                }
            }
            Console.WriteLine("Number of tails {0}",t);
            Console.WriteLine("Number of heads {0}",h);
            double tailpercent = (double)t / flip * 100;
            double headpercent = (double)h / flip * 100;
            Console.WriteLine("Tail percentage {0}",tailpercent);
            Console.WriteLine("Head percentage {0}",headpercent);
       }
    }
}
