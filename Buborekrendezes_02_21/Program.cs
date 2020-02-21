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
            //FELADAT1:
            //
            //Console.WriteLine("Add meg a tömb elemszámát!");
            //int elemszam = Convert.ToInt32(Console.ReadLine());

            //int[] tomb = new int[elemszam];
            //Random rnd = new Random();


            //int max = int.MinValue;
            //int maxHely = -1;
            //Console.WriteLine();
            //Console.WriteLine("A tömb elemei:");
            //for (int i = 0; i < tomb.Length; i++)
            //{
            //    tomb[i] = rnd.Next(-30, 41);
            //    Console.Write("{0} ", tomb[i]);
            //    if(tomb[i]> max)
            //    {
            //        max = tomb[i];
            //        maxHely = i;
            //    }

            //}

            //Console.WriteLine("\n\nA legnagyobb eleme: {0}",max);
            //Console.WriteLine("Indexe: {0}\n",maxHely);

            //Console.WriteLine("A tömb rendezve:");

            //for (int i = tomb.Length-1; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if(tomb[j] > tomb[j + 1])
            //        {
            //            int temp = tomb[j + 1];
            //            tomb[j + 1] = tomb[j];
            //            tomb[j] = temp;
            //        }
            //    }
            //}

            //foreach (var item in tomb)
            //{
            //    Console.Write("{0} ",item);
            //}


            //FELADAT2:

            List<int> marcius = new List<int>();
            Random rnd = new Random();

            int sum = 0;
            int hanyszor1024f = 0;

            Console.WriteLine("A havi adatforgalom:");
            
            for (int i = 0; i < 31; i++)
            {
                marcius.Add(rnd.Next(100, 2501));
                Console.Write("{0} ",marcius[i]);

                sum += marcius[i];

                if (marcius[i] > 1024) hanyszor1024f++;
            }

            Console.WriteLine("\n\n200-500 MB közötti forgalom:");
            for (int i = 0; i < marcius.Count; i++)
            {
                if(marcius[i]>200 && marcius[i]<500)
                    Console.WriteLine("Március {0}. {1} MB",i+1,marcius[i]);
            }

            Console.WriteLine("\nAz átlagos adatmennyiség: {0:0.00}",(double)sum/marcius.Count);
            Console.WriteLine("Ennyiszer volt 1GB feletti forgalom a hónapban: {0}",hanyszor1024f);

            int index = 0;

            while (index<marcius.Count && marcius[index]!=2000)
            {
                index++;
            }

            if(index<marcius.Count)
                Console.WriteLine("Igen volt, a {0}. napon!", index + 1);
            else
                Console.WriteLine("Nem volt ilyen!");

            //bool volt = false;
            //while (index<marcius.Count && !volt)
            //{
            //    if (marcius[index] == 2000)
            //        volt = true;
            //    index++;
            //}

            //Console.WriteLine(volt);

            Console.ReadKey();

        }
    }
}
