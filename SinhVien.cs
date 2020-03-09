using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class SinhVien
    {
        protected string masv;
        protected string name;
        protected float diem;
        protected string demodemo;




        public string Result = "";
        public string Ten { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(string masv,string name,float diem)
        {
            this.masv = masv;
            this.name = name;
            this.diem = diem;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Masv
        {
            get { return masv; }
            set { masv = value;}
        }
        public float Diem
        {
            get { return diem; }
            set { diem = value; }
        }
        public void Nhap()
        {
            Console.WriteLine("Ma sinh vien :");
            masv = Console.ReadLine();
            Console.WriteLine("Ho ten sinh vien :");
            name = Console.ReadLine();
            name = name.Trim();
            while (name.IndexOf("  ") != -1)
            {
                name = name.Replace("  ", " ");
            }
            string[] SubName = name.Split(' ');

            for (int i = 0; i < SubName.Length; i++)
            {
                string FirstChar = SubName[i].Substring(0, 1);
                string OtherChar = SubName[i].Substring(1);
                SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                Result += SubName[i] + " ";
            }

            for (int i = SubName.Length - 1; i >= 0; i--)
            {
                string FirstChar = SubName[i].Substring(0, 1);
                string OtherChar = SubName[i].Substring(1);

                SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                Ten += SubName[i];
            }

            Console.WriteLine("Diem trung binh hoc ky :");
            diem = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Ma sinh vien : {0}", masv);
            Console.WriteLine("Ho ten sinh vien : {0}",Result);
            Console.WriteLine("Diem trung binh hoc ky : {0}",diem);
        }

    }
}
