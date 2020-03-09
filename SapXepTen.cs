using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class SapXepTen : IComparer<SinhVien>// giao dien kha so sanh
    {
        public  int Compare(SinhVien x, SinhVien y)
        {
            return String.Compare(x.Ten, y.Ten);
        }
    }
}
