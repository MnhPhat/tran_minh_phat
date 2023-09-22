using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta;
            Console.WriteLine("nhap a: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap b: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap c: ");
            c = Convert.ToInt16(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
            else if (delta == 0) 
            {
                double x = -b / (2 * a);
                Console.WriteLine("phuong trinh co nghiem kep " + x); 
            }
            else
            {
                double x1=(-b/Math.Sqrt(delta)/2*a);
                double x2= (-b / Math.Sqrt(delta) / 2 * a);
                Console.WriteLine("phuong trinh co 2 nghiem phan biet: ");
                Console.WriteLine("x1= " + x1);
                Console.WriteLine("x2= " + x2);
                

            }
            Console.ReadKey();
        }
    }
}
