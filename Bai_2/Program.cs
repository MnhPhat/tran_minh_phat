using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    internal class Program
    {
        public static bool checkNamNhuan(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            return false;

        }
        static void Main(string[] args)
        {
            int month = 1, year = 12, day=0;

            Console.WriteLine("Month: ");
            month = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Year: ");
            year = Convert.ToInt16(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: day = 31; break;
                case 4:
                case 6:
                case 9:
                case 11: day = 30; break;
                case 2:
                    {
                        break;
                        if (checkNamNhuan(year) == true)
                            day = 29;
                        else
                        {
                            day = 28; break;
                        }
                    }
                    
            }
            Console.WriteLine("ngay: " +day.ToString());
            Console.ReadKey();
           
        }
    }
}
