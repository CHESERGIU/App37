using System;

namespace App37
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int N = Convert.ToInt32(input);
            decimal[,] stock = new decimal[N, 3];
            for (int i = 0; i < N; i++)
            {
                string console = Console.ReadLine();
                string[] quantity = console.Split(' ');
                for (int j = 0; j < 3; j++)
                    stock[i, j] = Convert.ToDecimal(quantity[j]);
            }
            decimal[] store = new decimal[N];
            for (int s = 0; s < N; s++)
            {
                store[s] = 0;
                for (int t = 0; t < 3; t++)
                {
                    store[s] += stock[s, t];
                }
            }
            decimal Sum;
            for (int p = 0; p < N; p++)
            {
                Sum = store[p];
                Console.WriteLine("{0} {1}: {2}", "Livada", p + 1, String.Format("{0:0}", Sum));
            }
            
            decimal[] tree = new decimal[3];
            for (int y = 0; y < 3; y++)
            {
                tree[y] = 0;
                for (int x = 0; x < N; x++)
                    tree[y] += stock[x, y];
            }
            
            decimal[] trees = new decimal[4];
            for (int y = 0; y < 3; y++)
            {
                trees[y] = 0;
                for (int x = 0; x < N; x++)
                    trees[y] += stock[x, y];
            }
            Console.WriteLine("{0}: {1}", "Meri", String.Format("{0:0}", trees[0]));
            Console.WriteLine("{0}: {1}", "Peri", String.Format("{0:0}", trees[1]));
            Console.WriteLine("{0}: {1}", "Ciresi", String.Format("{0:0}", trees[2]));
            Console.ReadKey();
        }
    }
}
