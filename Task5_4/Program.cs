namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            int[] array2 = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 11);
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                array2[i] = array[9-i];
                Console.Write("{0} ", array2[i]);
            }
                                         
            Console.ReadKey();
        }
    }
}
