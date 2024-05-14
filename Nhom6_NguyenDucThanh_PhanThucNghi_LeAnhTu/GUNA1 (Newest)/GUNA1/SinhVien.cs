using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNA1
{
    public class SinhVien : KeThua
    {
        public SinhVien(string id) : base(id)
        {
        }
        public SinhVien() { }

        public SinhVien(string id, string ten, string diachi, DateTime ngaysinh, string email, string sdt, string gioitinh, string nganh, string matkhau) : base(id, ten, diachi, ngaysinh, email, sdt, gioitinh, nganh, matkhau)
        {
        }
    }
}
