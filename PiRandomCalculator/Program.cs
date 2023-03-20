

namespace PiRandomCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some number to calculate Pi with random numbers");
            Console.WriteLine("A higher number gets a higher accuration!");

            
            bool inputValid = int.TryParse( Console.ReadLine(), out int input);

            if(inputValid )
            {
                try
                {
                    Console.WriteLine(RandomPi(input)); ;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadKey();

        }


        public static double RandomPi(int accuration)
        {
            Random random = new Random();

            double circle = 0;
            double square = 0;

            if(accuration == 0) { throw new ArgumentException("Parameter cannot be zero", nameof(accuration)); }

            for (int i = 0; i < accuration; i++)
            {
                double[] randomPoint = { random.NextDouble(), random.NextDouble() };
                double d = Math.Sqrt(Math.Pow(randomPoint[0], 2.0) + Math.Pow(randomPoint[1], 2.0));

                if (d < 1.0)
                {
                    circle++;
                }
                square++;

            }

            return 4 * circle/square;

        }
    }
}