using EFC_03_QuanLyVatTu.Helper;
using EFC_03_QuanLyVatTu.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03_QuanLyVatTu.Models
{
    public class PhieuXuat
    {
        public int PhieuXuatId { get; set; }
        public string MaPhieu { get; set; }
        public string TieuDe { get; set; }
        public DateTime NgayXuat { get; set; }

        public List<ChiTietPhieuXuat> ListChiTietPhieuXuat { get; set; }

        public void Input()
        {
            MaPhieu = InputHelper.InputString(QuanLyVatTuRes.MaPhieu);
            TieuDe = InputHelper.InputString(QuanLyVatTuRes.TieuDe);
            NgayXuat = InputHelper.InputDateTime(QuanLyVatTuRes.NgayXuat, QuanLyVatTuRes.ErrorNgayXuat);
        }

        public void Output()
        {
            Console.WriteLine($"Ma phieu: {MaPhieu}\n" +
                $"Tieu de: {TieuDe}\n" +
                $"Ngay nhap: {NgayXuat.ToShortDateString()}");
        }
    }
}
