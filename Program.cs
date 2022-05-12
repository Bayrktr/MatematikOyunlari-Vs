using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmiralBatti2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgale = new Random();
            int a = 0;
            int puan = 0;
            while (a < 3)
            {
                int x = 0;
                int y = 0;
                if (x != 0 && y != 0)
                {
                    x = rastgale.Next(x-1,x+1);
                    y = rastgale.Next(y-1,y+1);
                    Console.WriteLine("X:", x);
                    Console.WriteLine("Y:", y);
                }
                else
                {
                    x = rastgale.Next(1,5);
                    y = rastgale.Next(1,5);
                    Console.WriteLine(x);
                    Console.WriteLine(y);
                }
                int controlX;
                int controlY;
                string xTahmin = Console.ReadLine();
                string yTahmin = Console.ReadLine();
                controlX = Convert.ToInt32(xTahmin);
                controlY = Convert.ToInt32(yTahmin);
                if (controlX < 1 || controlX > 5 || controlY < 1 || controlY > 5)
                {
                    Console.WriteLine("Tekrar Dene");
                }
                else
                {
                    if (controlX == x || controlY == y)
                    {
                        puan = puan + 10;
                    }
                    a++;
                }
            }
            Console.WriteLine(puan);
            Console.WriteLine("Done");
            Console.ReadLine();

        }
    }
}
