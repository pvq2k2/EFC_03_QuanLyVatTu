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
    public class ChiTietPhieuNhap
    {
        public int ChiTietPhieuNhapId { get; set; }
        [Required]
        public int SoLuongNhap { get; set; }
        public int VatTuId { get; set; }
        public VatTu VatTu { get; set; }
        public int PhieuNhapId { get; set; }
        public PhieuNhap PhieuNhap { get; set; }

        public void Input() {
            SoLuongNhap = InputHelper.InputInt(QuanLyVatTuRes.SoLuongNhap, QuanLyVatTuRes.ErrorNhapSo);
            VatTuId = InputHelper.InputInt(QuanLyVatTuRes.VatTuId, QuanLyVatTuRes.ErrorNhapSo);
            PhieuNhapId = InputHelper.InputInt(QuanLyVatTuRes.PhieuNhapId, QuanLyVatTuRes.ErrorNhapSo);
        }

        public void Input(int phieuNhapId)
        {
            SoLuongNhap = InputHelper.InputInt(QuanLyVatTuRes.SoLuongNhap, QuanLyVatTuRes.ErrorNhapSo);
            VatTuId = InputHelper.InputInt(QuanLyVatTuRes.VatTuId, QuanLyVatTuRes.ErrorNhapSo);
            PhieuNhapId = phieuNhapId;
        }

        public void Output() {
            Console.WriteLine(SoLuongNhap);
        }
    }
}
