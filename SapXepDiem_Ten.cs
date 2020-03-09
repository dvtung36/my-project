using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class SapXepDiem_Ten : IComparer<SinhVien>
    {
        public int Compare(SinhVien x, SinhVien y)
        {

            if (x.Diem > y.Diem) return 1;
            else if (x.Diem == y.Diem) return String.Compare(x.Ten, y.Ten);
            else return -1;
        }
    }
}
