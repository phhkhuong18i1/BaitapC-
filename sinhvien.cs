using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien1
{
    class sinhvien
    { 
       public string masv;
        float toan;
        float ly;
        float hoa;
        //default constructor
        public sinhvien()
        {
            this.masv = "01";
            this.toan =(float) 7.5;
            this.ly = (float)8.5;
            this.hoa = (float)6.0;
        }
        //tham so hoa constructor
        public sinhvien(string masv,float toan,float ly, float hoa)
        {
            this.masv = masv;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;

        }
        public void nhap()
        {
            Console.WriteLine("Nhap ma sinh vien:");
            this.masv = Console.ReadLine();
            Console.WriteLine("nhap diem toan");
            this.toan = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem ly:");
            this.ly = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem hoa:");
            this.hoa = float.Parse(Console.ReadLine());


        }
        public float tinhTB()
        {
            float tb = (this.toan + this.ly + this.hoa) / 3;
            return tb;
        }
        public void intt()
        {
            Console.WriteLine("sinh vien ma {0} co diem trung binh la {1}", this.masv , this.tinhTB());
        }
       
        }
    }

