using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{   // dang nhap
    
    public class DAL_Taikhoan
    {
        public DataTable GetTaikhoan(string taikhoan, string matkhau, string Phanquyen)
        {
           string query = $"select * from Dangnhap where Username = N'{taikhoan}' and Pass = N'{matkhau}' and Phanquyen = N'{Phanquyen}'";
           return DBconnect.Instance.ExecuteQuery(query);
        }

    }

    // vao form dang ky
    public class DAL_Dangky
    {
        public DataTable GetDangky(string Phanquyen)
        {
            string query = $"select * from Dangnhap where Phanquyen = N'{Phanquyen}'";
            return DBconnect.Instance.ExecuteQuery(query);
        }
    }
    // lấy tài khoản và email từ form đăng nhập
    public class DAL_Doimk
    {
        public DataTable GetDoimk(string Taikhoan,string Email)
        {
            string query = $"select * from Dangnhap where Username  = N'{Taikhoan}' and Email = N'{Email}'";
            return DBconnect.Instance.ExecuteQuery(query);
        }
    }
}
