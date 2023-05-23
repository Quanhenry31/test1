using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class BUS_Phieumuon
    {
        DAL_Phieumuon pm = new DAL_Phieumuon();
        public DataTable Phieumuon()
        {
            return pm.Phieumuon();
        }
        public void themPhieumuon(Phieumuon PM)
        {
             pm.themPhieumuon(PM);
        }
        public void suaPhieumuon(Phieumuon PM)
        {
            pm.suaPhieumuon(PM);
        }
        public void xoaPhieumuon(string Sothe)
        {
            pm.xoaPhieumuon(Sothe);
        }
        public DataTable Getsothe()
        {
            return pm.Getsothe();
        }
        public DataTable Getmatt()
        {
            return pm.Getmatt();
        }
        public DataTable Timkiem(string keyword)
        {
            return pm.Timkiem(keyword); 
        }
    }
}
