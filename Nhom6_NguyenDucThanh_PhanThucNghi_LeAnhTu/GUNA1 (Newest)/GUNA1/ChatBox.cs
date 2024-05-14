using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNA1
{
    public class ChatBox
    {
        private string magiangvien;
        private string masinhvien;
        private string ten;
        
        private int manhom;
        private string noidungchat;
        private DateTime thoigian;
        public ChatBox() { }

        public ChatBox(string magiangvien, string masinhvien, string ten, int manhom, string noidungchat, DateTime thoigian)
        {
            Magiangvien = magiangvien;
            Masinhvien = masinhvien;
            Ten = ten; 
            Manhom = manhom;
            Noidungchat = noidungchat;
            Thoigian = thoigian;

        }
        public string Masinhvien { get { return masinhvien; } set { masinhvien = value; } }
        public string Magiangvien { get { return magiangvien; } set { magiangvien = value; } }
        public string Ten { get { return ten; } set { ten = value; } }


        public string Noidungchat { get {  return noidungchat; } set {  noidungchat = value; } }
        public int Manhom { get { return manhom; } set { manhom = value; } }
        public DateTime Thoigian { get {  return thoigian; } set {  thoigian = value; } }
    }
}
