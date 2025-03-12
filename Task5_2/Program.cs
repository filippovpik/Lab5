namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();

            int pos = 0;
            int neg = 0;
            int zer = 0;


            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-20, 21);
                Console.Write("{0} ", array[i]);

                if (array[i] > 0)
                {
                    pos++;
                }

                if (array[i] < 0)
                {
                    neg++;
                }

                if (array[i] == 0)
                {
                    zer++;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Количество положительных: {0}", pos);
            Console.WriteLine("Количество отрицательных: {0}", neg);
            Console.WriteLine("Количество равных нулю: {0}", zer);
            Console.ReadKey();
        }
    }
}
