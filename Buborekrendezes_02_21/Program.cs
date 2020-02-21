using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buborekrendezes_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a tömb elemszámát!");
            int elemszam = Convert.ToInt32(Console.ReadLine());

            int[] tomb = new int[elemszam];
            Random rnd = new Random();


            int max = int.MinValue;
            int maxHely = -1;
            Console.WriteLine();
            Console.WriteLine("A tömb elemei:");
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-30, 41);
                Console.Write("{0} ", tomb[i]);
                if(tomb[i]> max)
                {
                    max = tomb[i];
                    maxHely = i;
                }

            }

            Console.WriteLine("\n\nA legnagyobb eleme: {0}",max);
            Console.WriteLine("Indexe: {0}\n",maxHely);

            Console.WriteLine("A tömb rendezve:");

            for (int i = tomb.Length-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if(tomb[j] > tomb[j + 1])
                    {
                        int temp = tomb[j + 1];
                        tomb[j + 1] = tomb[j];
                        tomb[j] = temp;
                    }
                }
            }

            foreach (var item in tomb)
            {
                Console.Write("{0} ",item);
            }
            Console.ReadKey();

        }
    }
}
