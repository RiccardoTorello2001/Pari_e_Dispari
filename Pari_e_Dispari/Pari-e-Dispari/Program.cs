using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pari_e_Dispari
{
    class Program
    {
        public static void Pari()
        {

            for (int i = 0; i < 200; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }


        }
        public static void Dispari()
        {

            for (int i = 0; i < 200; i++)
            {
                if(i%2!=0)
                {
                    Console.Write(i + " ");
                }
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("i numeri pari sono:");
            Pari();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("i numeri dispari sono:");
            Dispari();
            Console.ReadLine();
        }
    }
}
