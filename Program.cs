using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG2_20192_P1_3_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan banyaknya N : ");
            int n = Convert.ToInt16(Console.ReadLine());
            while(n > 1)
            {
                Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", n, n-1);
                n--;
            }
            Console.WriteLine("Anak ayam turun {0}, mati satu tinggal induknya",n);
        }
    }
}
