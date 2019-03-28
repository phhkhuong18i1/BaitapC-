using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap danh sach cua sach:");
            n = Int32.Parse(Console.ReadLine());
            Sachgiaokhoa[] mang = new Sachgiaokhoa[n];
            for (int i = 0; i < n; i++)
            {
                mang[i] = new Sachgiaokhoa();
                mang[i].nhap();
                mang[i].In();
            }
            Console.ReadLine();
            Sachgiaokhoa s1 = new Sachgiaokhoa();
            s1.nhap();
            s1.In();
            Console.ReadLine();
        }
    }
}
