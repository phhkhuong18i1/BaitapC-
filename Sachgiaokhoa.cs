using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapc
{
    class Sachgiaokhoa:Sach
    {
        
        string tinhtrang;
       public Sachgiaokhoa()
            : base()
        {
            
            this.tinhtrang = "moi";
        }
        public new void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap tinh trang sach:");
            this.tinhtrang = Console.ReadLine();
        }
        public double tinhtien()
        {
            double tinh = 0;
            if (this.tinhtrang == "moi")
             tinh = base.dongia * base.soluong; 
            if (this.tinhtrang=="cu")
            
                 tinh =base. dongia * base.soluong * 0.5;
            
            return tinh;
        }
        public new void In()
        {

            Console.WriteLine("MA sach {0} co tong tien la {1}" , this.masach, this.tinhtien());
        }
            
    }
}
