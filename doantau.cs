using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class doantau
    {
        string matau;
        int sokhach;
        public void nhap()
        {
            Console.WriteLine("nhap ma doan tau:");
            this.matau = Console.ReadLine();
            Console.WriteLine("nhap so khach:");
            this.sokhach = Convert.ToInt32(Console.ReadLine());
        }
        public int tinhtien()
        {
            int tien;
            if (this.sokhach < 100) tien = this.sokhach * 100000;
            else tien = this.sokhach * 80000;
            return tien;
        }
        public void intt()
        {
            Console.WriteLine("Doan tau co ma {0} co tien la {1}:", this.matau, this.tinhtien());

        }
        
    }
}
