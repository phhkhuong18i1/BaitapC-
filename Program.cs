using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap so doan tau:");
            n = Int32.Parse(Console.ReadLine());
            doantau[] mangdt = new doantau[100];
            for (int i=0;i<n;i++)
            {
                mangdt[i] = new doantau();
                mangdt[i].nhap();
                mangdt[i].intt();

            }
            doantau tau1 = new doantau();
            tau1.nhap();
            tau1.intt();
            Console.ReadLine();
        }
    }
}
