using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap so sinh vien:");
            n = Int32.Parse(Console.ReadLine());
            sinhvien[] sv = new sinhvien[n];
            for (int i=0;i<n;i++)
            {
                sv[i] = new sinhvien();
                sv[i].nhap();
                sv[i].intt();
            }
            
            
                
                float min = sv[0].tinhTB();
                for (int i = 1; i < n; i++)
                {
                    if (sv[i].tinhTB() < min)
                        min = sv[i].tinhTB();
                    
                }
            Console.WriteLine("SV diem thap nhat la:{0}", min);
            Console.WriteLine("thong tin sinh vien trong ma SV co chu IT la:");
            for (int i=0;i<n;i++)
            {
                if (sv[i].masv.Contains("IT"))
                    Console.WriteLine("sinh vien ma {0} co diem TB la:{1}", sv[i].masv, sv[i].tinhTB());
                        
            }
            
            for (int j = 0; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (sv[k].tinhTB() < sv[j].tinhTB())
                    {
                        sinhvien sx = new sinhvien();
                        sx = sv[j];
                        sv[j] = sv[k];
                        sv[k] = sx;
                    }
                }
            }
            Console.WriteLine(" thong tin sinh vien sau khi xap sep la:");
            for (int j = 0; j < n; j++)
                Console.WriteLine("sinh vien ma {0} co diem TB la : {1}", sv[j].masv, sv[j].tinhTB());
                Console.ReadLine();

        }
    }
}
