using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {

        delegate void testdelegate(int a, int b);

        static void fibo(int a, int b)
        {
            int adet = 39;

            Console.Write(a + " " + b + " ");
            ArrayList list = new ArrayList();
            int say = 0;
            for (int i = 3; i <= adet; i++)
            {
                int c = a + b;
                Console.Write(c + " ");
                if (c % 2 == 0)
                {
                    say++;
                    list.Add(c);
                }
                a = b; b = c;
            }
            Console.WriteLine("\n{0} tane çift sayı var", say); Console.WriteLine("Sayılar: "); foreach (var sayi in list) { Console.Write(sayi + " "); }
            Console.Read();
        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            var td = new testdelegate(fibo);
            td(a, b);
            Console.Read();


        }
    }
}
