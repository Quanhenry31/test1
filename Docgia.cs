using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Docgia
    {

        public string Sothe { get; set; }
        public string Hoten { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        public string Lienhe { get; set; }
        public string Email { get; set; }
        public string Quequan { get; set; }
        public string Malop { get; set; }
        public string Makhoa { get; set; }

        public Docgia() { }
        public Docgia(string Sothe, string Hoten, DateTime Ngaysinh, string Gioitinh, string Lienhe, string Email, string Quequan, string Malop, string Makhoa)
        {
            this.Sothe = Sothe;
            this.Hoten = Hoten;
            this.Ngaysinh = Ngaysinh;
            this.Gioitinh = Gioitinh;
            this.Lienhe = Lienhe;
            this.Email = Email;
            this.Quequan = Quequan;
            this.Malop = Malop;
            this.Makhoa = Makhoa;

        }





    }
}
