namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();

            int max = 0;
            int min = 0;
            int iMax = 0;
            int iMin = 0;


            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 51);
                Console.Write("{0} ", array[i]);
            }

            max = array[0];
            min = array[0];

            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    iMax = i+1;
                }

                if (array[i] < min)
                {
                    min = array[i];
                    iMin = i+1;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Максимальное число {0} находится на {1} месте", max, iMax);
            Console.WriteLine("Минимальное число {0} находится на {1} месте", min, iMin);
            Console.ReadKey();
        }
    }
}
