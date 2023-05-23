using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
        // hiển thị danh sách sách ra màn hình
    public class DAL_Dausach
    {
       public DataTable GetDausach()
        {
            string query = $"SP_hienThiSach";
            return DBconnect.Instance.ExecuteQuery(query);
        }


        public void addDauSach(Dausach ds)
        {
            string query = $"SP_ThemDauSach @maDS , @tenSach , @namXB , @ngayNhap , @Gia , @soLuong , @Linhvuc , @Nhaxuatban , @Tacgia , @tinhTrang ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                ds.maDS,
                ds.tenSach,
                ds.namXB,
                ds.ngayNhap,
                ds.Gia,
                ds.soLuong,
                ds.Linhvuc,
                ds.Nhaxuatban,
                ds.Tacgia,
                ds.tinhTrang
            });
        }

        public void updateDauSach(Dausach ds)
        {
            string query = $"SP_SuaDauSach @maDS , @tenSach , @namXB , @ngayNhap , @Gia , @soLuong , @Linhvuc , @Nhaxuatban , @Tacgia , @tinhTrang";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                ds.maDS,
                ds.tenSach,
                ds.namXB,
                ds.ngayNhap,
                ds.Gia,
                ds.soLuong,
                ds.Linhvuc,
                ds.Nhaxuatban,
                ds.Tacgia,
                ds.tinhTrang
            });
        }

        public void deleteDauSach(string maDS)
        {
            string query = $"Sp_XoaDauSach @maDS";
            DBconnect.Instance.ExecuteQuery(query , new object[] { maDS });
        }
        public DataTable Timkiem(string keyword)
        {
            string query = $"SP_Tim_Dausach @key";
            return DBconnect.Instance.ExecuteQuery(query , new object[] {keyword});
        }
    }
}
