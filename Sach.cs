using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapc
{
    class Sach
    {
        protected string masach;

        protected string ngaynhap;

        protected int dongia;

        protected int soluong;
        public Sach()
        {
            this.masach = "01";
            this.ngaynhap = "13/02/2109";
            this.dongia = 50000;
            this.soluong = 10;


        }
        public void nhap()
        {
            Console.WriteLine("nhap ma sach:");
            this.masach = Console.ReadLine();
            Console.WriteLine("ngay nhap:");
            this.ngaynhap = Console.ReadLine();
            Console.WriteLine("nhap don gia:");
            this.dongia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so luong:");
            this.soluong = Convert.ToInt32(Console.ReadLine());
        }
        public void In()
        {
            Console.WriteLine("Ma sach{0} nhap ngay{1} co don gia {2} va so luong {3}" + this.masach, this.ngaynhap, this.dongia, this.soluong);
        }
    }
}
