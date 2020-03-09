using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program 
    {
        static void Main(string[] args)
        {
            int n;
            //SinhVien[] sv;
            Console.WriteLine("So sinh vien can sap xep:");
            n = int.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[n];    
            for (int i = 0; i < n; i++)  
            {
                Console.WriteLine("Nhap thong tin sinh vien thu {0}", i + 1);
                sv[i]= new SinhVien();
                sv[i].Nhap();
            }
            SapXepDiem sxd = new SapXepDiem();
            SapXepTen sxt = new SapXepTen();
            SapXepDiem_Ten sxdt = new SapXepDiem_Ten();

            List<SinhVien> svlish= new List<SinhVien>();
            for(int i = 0; i < n; i++)
            {
                svlish.Add(sv[i]);
            }
            svlish.Sort(sxd);
            Console.WriteLine("                 Danh sach Sinh Vien sau khi sap xep theo diem:");
            foreach (SinhVien svf in svlish)
            {
                svf.Xuat();
             
            }

            svlish.Sort(sxt);
            Console.WriteLine("                 Danh sach Sinh Vien sau khi sap xep theo ten:");
            foreach (SinhVien svf in svlish)
            {
                svf.Xuat();

            }
            svlish.Sort(sxdt);
            Console.WriteLine("                 Danh sach Sinh Vien sau khi sap xep theo diem va neu bang diem nhau thi sap xep theo ten:");
            foreach (SinhVien svf in svlish)
            {
                svf.Xuat();

            }


            Console.ReadKey();




        }

    }
}
