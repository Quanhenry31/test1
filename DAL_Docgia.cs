using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    // hien thi doc gia ra mh
    public class DAL_Docgia
    {
        public DataTable GetDocgia()
        {
            string query = $"hienThi_dg";
            return DBconnect.Instance.ExecuteQuery(query);
        }

        public DataTable GetLop()
        {
            string query = $"select * from Lop";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public DataTable Getkhoa()
        {
            string query = $"select * from Khoa";
            return DBconnect.Instance.ExecuteQuery(query);
        }

        public void addDocGia(Docgia dg)
        {
            string query = $"SP_ThemDocGia @Sothe , @Hoten , @NgaySinh , @Gioitinh , @Lienhe , @Email , @Quequan , @Malop , @Makhoa ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                dg.Sothe,
                dg.Hoten,
                dg.Ngaysinh,
                dg.Gioitinh,
                dg.Lienhe,
                dg.Email,
                dg.Quequan,
                dg.Malop,
                dg.Makhoa
            });
        }



        public void updateDocGia(Docgia dg)
        {
            string query = $"SP_SuaDocGia @Sothe , @Hoten , @NgaySinh , @Gioitinh , @Lienhe , @Email , @Quequan , @Malop , @Makhoa ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                dg.Sothe,
                dg.Hoten,
                dg.Ngaysinh,
                dg.Gioitinh,
                dg.Lienhe,
                dg.Email,
                dg.Quequan,
                dg.Malop,
                dg.Makhoa
            });
        }

        public void deleteDocGia(string Sothe)
        {
            string query = $"SP_XoaDocGia @Sothe ";
            DBconnect.Instance.ExecuteQuery(query, new object[] { Sothe });
        }
        public DataTable Timkiem(string keyword)
        { 
            string query = $"SP_Tim_Docgia @key";
            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }

    }
}
