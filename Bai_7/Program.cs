using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7
{
    internal class Program
    {   public static bool KTnguyento(int n)
        {
            if (n < 2)
            { 
                return false; 
            }
            else 
            {
                for (int i = 2; i < Math.Sqrt(n)+1; i++) 
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;

            }
            
        }
        static void Main(string[] args)
        {
            int n;
           
            Console.WriteLine("nhap n");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i = 1;i < n;i++)
            {
                if (KTnguyento(i) == true)
                {
                    Console.WriteLine(" so nguyen to la : " + i);
                    
                }

            }
            Console.ReadKey();
        }
    }
}
