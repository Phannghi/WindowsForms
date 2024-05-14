using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUNA1
{
    public class DangKy
    {
        private string maluanvan;
        private string tenluanvan;
        private string masinhvien;
        private string tensinhvien;
        private int manhom;
        private int sotask;
        private int sohoanthanh;
        private string danhgia;
        private string xetduyet;
        private int tasktulam;
        private float chamdiem;
        public DangKy() { }
        public DangKy(string maluanvan, string tenluanvan, string masinhvien, string tensinhvien, int manhom, int sotask, int sohoanthanh, string danhgia, string xetduyet, int tasktulam, float chamdiem)
        {
            Maluanvan = maluanvan;
            Tenluanvan = tenluanvan;
            Masinhvien = masinhvien;
            Tensinhvien = tensinhvien;
            Manhom = manhom;
            Sotask = sotask;
            Sohoanthanh = sohoanthanh;
            Danhgia = danhgia;
            Xetduyet = xetduyet;
            Tasktulam = tasktulam;
            Chamdiem = chamdiem;
        }
        public string Maluanvan { get { return maluanvan; } set { maluanvan = value; } }
        public string Tenluanvan { get { return tenluanvan; } set { tenluanvan = value; } }
        public string Masinhvien { get {  return masinhvien; } set { masinhvien = value; } }

        public string Tensinhvien { get { return tensinhvien; } set { tensinhvien = value; } }
        public string Danhgia { get { return danhgia; } set { danhgia = value; } }
        public int Manhom { get {  return manhom; } set {  manhom = value; } }

        public int Sotask { get {  return sotask; } set {  sotask = value; } }
        public int Sohoanthanh { get {  return sohoanthanh; } set {  sohoanthanh = value; } }
        public string Xetduyet { get { return xetduyet; } set {  xetduyet = value; } }

        public int Tasktulam { get { return tasktulam; } set { tasktulam = value; } }
        public float Chamdiem { get { return chamdiem; } set { chamdiem = value; } }


    }
}
