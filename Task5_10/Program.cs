using System.Security.AccessControl;

namespace Task5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 3;
            int fRaw = 0;
            int fCol = 0;
            int fMainDia = 0;
            int fSecDia = 0;

            int[,] array = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++) //create a matrix
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rnd.Next(0, 2);
                    Console.Write("{0,4} ", array[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++) //search in main diagonal
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j & array[i, j] == 1)
                    {
                        fMainDia = fMainDia + 1;
                    }
                }
            }

            for (int i = 0; i < n; i++) //search in secondary diagonal
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1 & array[i, j] == 1)
                    {
                        fSecDia = fSecDia + 1;
                    }
                }
            }

            for (int i = 0; i < n; i++) //search in Raws
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] == 1)
                    {
                        fRaw = fRaw + 1;
                    }
                }
                if (fRaw == n)
                {
                    break;
                }
                fRaw = 0;
            }

            for (int j = 0; j < n; j++) //search in columns
            {
                for (int i = 0; i < n; i++)
                {
                    if (array[i, j] == 1)
                    {
                        fCol = fCol + 1;
                    }
                }
                if (fCol == n)
                {
                    break;
                }
                fCol = 0;
            }

            if (fMainDia == n | fSecDia == n | fRaw == n | fCol == n)
            {
                Console.WriteLine("Крестики выиграли");
            }

            Console.ReadKey();
        }
    }
}
