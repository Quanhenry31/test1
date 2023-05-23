using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Globalization;
using DocumentFormat.OpenXml.Bibliography;
using Novacode;

namespace BUS
{
    public class BUS_Dausach
    {
        // hien thi dau sach

        DAL_Dausach ds = new DAL_Dausach();
        public DataTable GetDausach()
        {
            return ds.GetDausach();
        }
        public void addDauSach(Dausach dausach)
        {
            ds.addDauSach(dausach);
        }
        public void updateDauSach(Dausach dausach)
        {
            ds.updateDauSach(dausach);
        }
        public void deleteDauSach(string maDS)
        {
            ds.deleteDauSach(maDS);
        }
        public DataTable Timkiem(string keyword)
        {
            return ds.Timkiem(keyword);
        }

        public void KetXuatWord(string exportPath)
        {
           
            WordHelper.ExportToWord(ds.GetDausach(), "Template\\ViewBook_Template.docx", exportPath,new List<string>()
            {
                "ngayNhap",
                "Linhvuc",
                "Nhaxuatban",
                "tinhTrang"
            });
        }
        public void XuatExcel(string filePath)
        {
            ExcelHelper.WriteExcelFile(filePath, "Template\\a.xlsx", ds.GetDausach());
        }




    }
}
