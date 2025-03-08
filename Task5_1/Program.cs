namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();

            int nOdd = 0;
            int nEven = 0;
            string f = "null";

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                Console.Write("{0} ", array[i]);

                if (array[i] % 2 == 0)
                {
                    nEven++;
                }
                else
                {
                    nOdd++;
                }
                                
                }

            if (nEven > nOdd)
            {
                f = "Больше четных";
            }
            else
            {
                f = "Больше нечетных";
            }

            if (nEven == nOdd)
            {
                f = "Четных и нечетных поровну";
            }

                Console.WriteLine();
                Console.WriteLine(f);
                Console.ReadKey();
            }
        }
    }

