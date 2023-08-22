using EFC_03_QuanLyVatTu.Helper;
using EFC_03_QuanLyVatTu.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03_QuanLyVatTu.Models
{
    public class VatTu
    {
        public int VatTuId { get; set; }
        [Required]
        public string TenVatTu { get; set; }
        public int SoLuongTon { get; set; }

        public List<ChiTietPhieuNhap> ListChiTietPhieuNhap { get; set; }
        public List<ChiTietPhieuXuat> ListChiTietPhieuXuat { get; set; }

        public void Input() {
            TenVatTu = InputHelper.InputString(QuanLyVatTuRes.TenVatTu);
            SoLuongTon = InputHelper.InputInt(QuanLyVatTuRes.SoLuongTon, QuanLyVatTuRes.ErrorNhapSo);
        }

        public void InputDef()
        {
            TenVatTu = InputHelper.InputString(QuanLyVatTuRes.TenVatTu);
            SoLuongTon = 0;
        }

        public void Output() {
            Console.WriteLine($"{TenVatTu} - SLTK: {(SoLuongTon == 0 ? "Het hang" : SoLuongTon)}");
        }
    }
}
