using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dausach
    {
        public string maDS { get; set; }
        public string tenSach { get; set; }
        public DateTime namXB { get; set; }
        public DateTime ngayNhap { get; set; }
        public string Gia { get; set; }
        public int soLuong { get; set; }
        public string Linhvuc { get; set; }
        public string Nhaxuatban { get; set; }
        public string Tacgia { get; set; }
        public string tinhTrang { get; set; }
        

        public Dausach() { }

        public Dausach(string maDS, string tenSach, DateTime namXB, DateTime ngayNhap, string Gia, int soLuong, string Linhvuc, string Nhaxuatban, string Tacgia, string tinhTrang)
        {
            this.maDS = maDS;
            this.tenSach = tenSach;
            this.namXB = namXB;
            this.ngayNhap = ngayNhap;
            this.Gia = Gia;
            this.soLuong = soLuong;
            this.Linhvuc = Linhvuc;
            this.Nhaxuatban = Nhaxuatban;
            this.Tacgia = Tacgia;
            this.tinhTrang = tinhTrang;
        }
    }
}
