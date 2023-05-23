using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phieumuon
    {

        public string SoPhieu { get; set; }
        public string Sothe { get; set; }
        public string maDS { get; set; }
        public DateTime ngayMuon { get; set; }
        public DateTime ngayTra { get; set; }
        public string Matt { get; set; }
        public Phieumuon() { }
        public Phieumuon(string soPhieu, string sothe, string maDS, DateTime ngayMuon, DateTime ngayTra, string matt)
        {
            SoPhieu = soPhieu;
            Sothe = sothe;
            this.maDS = maDS;
            this.ngayMuon = ngayMuon;
            this.ngayTra = ngayTra;
            Matt = matt;
        }
    }
}
