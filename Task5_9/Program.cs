namespace Task5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 8;
            const int m = 4;
            int[,] array = new int[n, m];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = i * m + j + 1;
                    Console.Write("{0,4} ", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
