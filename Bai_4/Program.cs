using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
    internal class Program
    { 
       
        static void Main(string[] args)
          
        {
            int a, b, c;
            double chuvi=0;
            Console.WriteLine("nhap a: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap b: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap c: ");
            c= Convert.ToInt16(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                chuvi = (a + b + c);
                Console.WriteLine("chu vi la: " + chuvi.ToString());
            }
            else
            {
                Console.WriteLine("day ko phai la tam giac ");
            }
            Console.ReadKey();
        }
    }
}
