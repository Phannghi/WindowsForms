using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNA1
{
    public class KeThua
    {
        private string id;
        private string ten;
        private string diachi;
        private DateTime ngaysinh;
        private string email;
        private string sdt;
        private string gioitinh;
        private string nganh;
        private string matkhau;
     
        public KeThua(string id)
        {
            Id = id;
        }

        public KeThua() { }

        public KeThua(string id, string ten, string diachi, DateTime ngaysinh, string email, string sdt, string gioitinh, string nganh, string matkhau) : this(id)
        {
            this.ten = ten;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
            this.email = email;
            this.sdt = sdt;
            this.gioitinh = gioitinh;
            this.nganh = nganh;
            this.matkhau = matkhau;
        }

        public string Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }

}
