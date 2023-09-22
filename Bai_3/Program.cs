using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            double tong=0;
            Console.WriteLine("nhap n: ");
            n = Convert.ToInt16(Console.ReadLine());

            for (i=0;i<2*(n-1); i++)
            {
                tong = tong + i;
            }
            Console.WriteLine("ngay: " + tong.ToString());
            Console.ReadKey();
        }
    }
}
