using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Taikhoan
    {
        // dang nhap

        DAL_Taikhoan tk = new DAL_Taikhoan();
        public DataTable GetTaikhoan(string taikhoan, string matkhau, string Phanquyen)
        {
            return tk.GetTaikhoan(taikhoan,matkhau, Phanquyen);
        }


        public bool KiemTraTk(string taikhoan, string matkhau, string Phanquyen)
        {
            return GetTaikhoan(taikhoan, matkhau, Phanquyen).Rows.Count > 0;
        }

        // dang ky
        DAL_Dangky dk = new DAL_Dangky();
        public DataTable GetDangky(string Phanquyen)
        {
            return dk.GetDangky(Phanquyen);
        }
        // doi mk 
        DAL_Doimk mk = new DAL_Doimk();
        public DataTable Getdoimk(string Taikhoan , string Email )
        {
            return mk.GetDoimk(Taikhoan , Email);
        }
    }
}
