using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNA1
{

    public class GiangVien : KeThua
    {
        public GiangVien(string id) : base(id)
        {
        }
        public GiangVien() { }

        public GiangVien(string id, string ten, string diachi, DateTime ngaysinh, string email, string sdt, string gioitinh, string nganh, string matkhau) : base(id, ten, diachi, ngaysinh, email, sdt, gioitinh, nganh, matkhau)
        {
        }
    }

}
