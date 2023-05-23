using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using BUS;

namespace DLL
{
    // hien thi doc gia
    public class BUS_Docgia
    {
        DAL_Docgia dg = new DAL_Docgia();
        
        public DataTable GetDocgia()
        {
            return dg.GetDocgia();
        }

        public DataTable GetLop()
        {

            return dg.GetLop();
        }
        public DataTable Getkhoa()
        {
            return dg.Getkhoa();
        }

        public void addDocGia(Docgia docgia)
        {
            dg.addDocGia(docgia);
        }

        public void updateDocGia(Docgia docgia)
        {
            dg.updateDocGia(docgia);
        }
        public void deleteDocGia(string soThe)
        {
            dg.deleteDocGia(soThe);

        }
        public DataTable Timkiem(string keyword)
        {
            return dg.Timkiem(keyword);
        }



        public void KetXuatWord(string exportPath)
        {

            WordHelper.ExportToWord(dg.GetDocgia(), "Template\\ViewDocgia_Template.docx", exportPath, new List<string>()
            {
                "Gioitinh",
                "Email",
                "Quequan"
            });
        }
    }
}
