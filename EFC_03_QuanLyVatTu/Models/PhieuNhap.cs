using EFC_03_QuanLyVatTu.Helper;
using EFC_03_QuanLyVatTu.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03_QuanLyVatTu.Models
{
    public class PhieuNhap
    {
        public int PhieuNhapId { get; set; }
        public string MaPhieu { get; set; }
        public string TieuDe { get; set; }
        public DateTime NgayNhap { get; set; }

        public List<ChiTietPhieuNhap> ListChiTietPhieuNhap { get; set; }

        public void Input() {
            MaPhieu = InputHelper.InputString(QuanLyVatTuRes.MaPhieu);
            TieuDe = InputHelper.InputString(QuanLyVatTuRes.TieuDe);
            NgayNhap = InputHelper.InputDateTime(QuanLyVatTuRes.NgayNhap, QuanLyVatTuRes.ErrorNgayNhap);
        }

        public void Output() {
            Console.WriteLine($"Ma phieu: {MaPhieu}\n" +
                $"Tieu de: {TieuDe}\n" +
                $"Ngay nhap: {NgayNhap.ToShortDateString()}");
        }
    }
}
