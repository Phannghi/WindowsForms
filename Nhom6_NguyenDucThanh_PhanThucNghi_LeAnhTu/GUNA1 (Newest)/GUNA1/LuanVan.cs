using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNA1
{
    public class LuanVan
    {
        private string maluanvan;
        private string tenluanvan;
        private int soluong;
        private string mota;
        private string yeucau;
        private string congnghe;
        private string tengiangvien;
        private string task;
        private string xetduyet;
        public LuanVan( string maluanvan, string tenluanvan, int soluong, string mota, string yeucau, string congnghe, string tengiangvien, string task, string xetduyet)
        {
            Tenluanvan = tenluanvan;
            Maluanvan = maluanvan;
            Soluong = soluong;
            Mota = mota;
            Yeucau = yeucau;
            Congnghe = congnghe;
            Tengiangvien = tengiangvien;
            Task = task;
            Xetduyet = xetduyet;
        }

        public string Tenluanvan { get => tenluanvan; set => tenluanvan = value; }
        public string Maluanvan { get => maluanvan; set => maluanvan = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Yeucau { get => yeucau; set => yeucau = value; }
        public string Congnghe { get => congnghe; set => congnghe = value; }
        public string Tengiangvien { get => tengiangvien; set => tengiangvien = value; }
        public string Task { get => task; set => task = value; }

        public string Xetduyet { get => xetduyet; set => xetduyet = value; }
        public LuanVan()  { }

        
    }
}
