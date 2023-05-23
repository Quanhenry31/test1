using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Taikhoan
    {
        public string Username { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string Phanquyen { get; set; }
        public string Matma { get; set; }


        public Taikhoan() { }

        public Taikhoan(string Username, string Pass , string Email, string Phanquyen, string Matma)
        {
            this.Username = Username;
            this.Pass = Pass;
            this.Email = Email;
            this.Phanquyen = Phanquyen;
            this.Matma = Matma;
        }
    }
}
