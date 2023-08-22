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
    public class ChiTietPhieuXuat
    {
        public int ChiTietPhieuXuatId { get; set; }
        [Required]
        public int SoLuongXuat { get; set; }
        public int VatTuId { get; set; }
        public VatTu VatTu { get; set; }
        public int PhieuXuatId { get; set; }
        public PhieuXuat PhieuXuat { get; set; }

        public void Input()
        {
            SoLuongXuat = InputHelper.InputInt(QuanLyVatTuRes.SoLuongXuat, QuanLyVatTuRes.ErrorNhapSo);
            VatTuId = InputHelper.InputInt(QuanLyVatTuRes.VatTuId, QuanLyVatTuRes.ErrorNhapSo);
            PhieuXuatId = InputHelper.InputInt(QuanLyVatTuRes.PhieuXuatId, QuanLyVatTuRes.ErrorNhapSo);
        }

        public void Input(int phieuXuatId)
        {
            SoLuongXuat = InputHelper.InputInt(QuanLyVatTuRes.SoLuongXuat, QuanLyVatTuRes.ErrorNhapSo);
            VatTuId = InputHelper.InputInt(QuanLyVatTuRes.VatTuId, QuanLyVatTuRes.ErrorNhapSo);
            PhieuXuatId = phieuXuatId;
        }

        public void Output()
        {
            Console.WriteLine(SoLuongXuat);
        }
    }
}
