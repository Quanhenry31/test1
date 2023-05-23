using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    
    public class DAL_Phieumuon
    {
        public DataTable Phieumuon()
        {
            string query = $"hienthi_Phieumuon";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public void themPhieumuon(Phieumuon pm)
        {
            string query = $"SP_Them_PhienMuon @SoPhieu , @Sothe , @maDS , @ngayMuon , @ngayTra , @Matt";
            DBconnect.Instance.ExecuteQuery(query, new object[]
           {
                pm.SoPhieu,
                pm.Sothe,
                pm.maDS,
                pm.ngayMuon,
                pm.ngayTra,
                pm.Matt
           });
        }
        public void suaPhieumuon(Phieumuon pm)
        {
            string query = $"SP_Sua_Phieumuon @SoPhieu , @Sothe , @maDS , @ngayMuon , @ngayTra , @Matt";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                pm.SoPhieu,
                pm.Sothe,
                pm.maDS,
                pm.ngayMuon,
                pm.ngayTra,
                pm.Matt
            });
        }
        public void xoaPhieumuon(string Sophieu)
        {
            string query = $"SP_Xoa_Phieumuon @SoPhieu";
            DBconnect.Instance.ExecuteQuery(query, new object[] { Sophieu});
        }

        public DataTable Getsothe()
        {
            string query = $"select * from DocGia";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public DataTable Getmatt()
        {
            string query = $"select * from ThuThu";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public DataTable Timkiem(string keyword)
        {
            string query = "SP_Tim_Phieumuon @key ";

            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }
    }
}
