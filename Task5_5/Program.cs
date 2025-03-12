namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-50, 51);
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < 4; i++) //sort first 5 elements
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            for (int i = 5; i < n - 1; i++) //sort second 5 elements
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }


            Console.ReadKey();
        }
    }
}
