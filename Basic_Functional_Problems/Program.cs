using System;

namespace Basic_Functional_Problems
{
    /// <summary>
    /// UC1 - To find the percentage of head VS tail
    /// UC2 -  To find the year is leap year or not
    /// UC3 -  To find the power of 2
    /// UC4 - To find the nth harmonic number
    /// UC5 - To find the prime factors of a number
    /// UC6 -  To find the quotient and remainder 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to basic C# and functional problems!");

            while (true)
            {
                // '1' - is used to find the percentage of head VS tail
                // '2' - is used to find leap year or not
                // '3' -  is used to find power of 2
                // '4' - is used to find nth harmonic number
                // '5' -  is used to find prime factors
                // '6' -  is used to find quotient and remainder
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter number of times to filp a coin");
                        int flip = Convert.ToInt32(Console.ReadLine());
                        Program.FlipCoins(flip);
                        break;

                    case 2:
                        Console.WriteLine("Enter the year");
                        int year = int.Parse(Console.ReadLine());
                        Program.Leapyear(year);
                        break;

                    case 3:
                        Console.WriteLine("Enter the number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Program.Powerof2(n);
                        break;

                    case 4:
                        Console.WriteLine("Enter the number");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Program.HarmonicNumber(m);
                        break;

                    case 5:
                        Console.WriteLine("Enter the integer");
                        int prime = Convert.ToInt32(Console.ReadLine());
                        Program.Primefactors(prime);
                        break;

                    case 6:

                        Console.WriteLine("Enter the dividend");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the divisor");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Program.quorem(a,b);
                        break;

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
        
        // Function to find the leap year or not 
        public static void Leapyear(int year)
        {
            if((year % 4==0) && (year % 100 !=0) || (year % 400 ==0))
            {
                Console.WriteLine("{0} is Leap Year",year);
            }
            else
            {
                Console.WriteLine("{0} is not Leap Year",year);
            }
        }

        // Function to find te power of 2

        public static void Powerof2(int n)
        {
            Console.Write("[");
            for(int i=1;i<=n;i++)
            {
                Console.Write(Math.Pow(2, i) + " ");
            }
            Console.WriteLine("]");
        }

        // Function to find nth harmonic number
        public static void HarmonicNumber(int m)
        {
            int i;
            double s = 0.0;
            for(i=1;i<=m;i++)
            {
                Console.Write("1/{0} + ", i);
                s = s + 1 / (float)i;
            }
            Console.Write("nth number {0}", s);
        }

        // Function to compute prime factors of a number

        public static void Primefactors(int prime)
        {
            for(int i=1;i<=prime;i++)
            {
                if(prime%i==0)
                {
                    Console.WriteLine("Factors are {0} ",i);
                }
            }
        }

        //  Fuction to compute quotient and remainder
        public static void quorem(int a,int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine("Quotient is {0}",quotient);
            Console.WriteLine("Remainder is {0}",remainder);
        }
    }
}
