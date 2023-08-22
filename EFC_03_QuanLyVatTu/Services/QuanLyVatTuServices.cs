using EFC_03_QuanLyVatTu.Helper;
using EFC_03_QuanLyVatTu.IServices;
using EFC_03_QuanLyVatTu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03_QuanLyVatTu.Services
{
    public class QuanLyVatTuServices : IQuanLyVatTuServices
    {
        private readonly AppDbContext dbContext;

        public QuanLyVatTuServices()
        {
            dbContext = new AppDbContext();
        }

        public LogType HienThiDanhSachVatTu()
        {
            var ListVatTu = dbContext.VatTu.ToList();
            if (ListVatTu.Count() == 0) return LogType.DanhSachTrong;
            ListVatTu.ForEach(x => x.Output());
            return LogType.ThanhCong;
        }

        public LogType HienThiVatTuCanThem()
        {
            var ListVatTu = dbContext.VatTu.Where(x => x.SoLuongTon == 0).ToList();
            if (ListVatTu.Count() == 0) return LogType.DanhSachTrong;
            ListVatTu.ForEach(x => x.Output());
            return LogType.ThanhCong;
        }

        public LogType ThemMoiPhieuNhapHoacXuat()
        {
            while (true)
            {
                Console.WriteLine("1. Nhap phieu nhap");
                Console.WriteLine("2. Nhap phieu xuat");
                Console.WriteLine("3. Thoat");
                int chon = InputHelper.InputInt("Chon chuc nang: ", "Vui long nhap la so!");

                switch (chon)
                {
                    case 1:
                        ThemPhieuNhap();
                        break;
                    case 2:
                        ThemPhieuXuat();
                        break;
                    case 3:
                        return LogType.Thoat;
                    default:
                        Console.WriteLine("Vui long chon nhung chuc nang tren!");
                        break;
                }
            }
        }
        private LogType ThemPhieuNhap()
        {
            PhieuNhap phieuNhap = new PhieuNhap();
            phieuNhap.Input();
            dbContext.PhieuNhap.Add(phieuNhap);
            dbContext.SaveChanges();

            int SLChiTietPhieuNhap = InputHelper.InputInt("Nhap so luong chi tiet phieu nhap: ", "Vui long nhap vao la so!");
            var ListChiTietPhieuNhap = new List<ChiTietPhieuNhap>();

            for (int i = 0; i < SLChiTietPhieuNhap; i++)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();
                chiTietPhieuNhap.Input(phieuNhap.PhieuNhapId);

                var FindVatTuInPhieuNhap = dbContext.VatTu.FirstOrDefault(x => x.VatTuId == chiTietPhieuNhap.VatTuId);
                if (FindVatTuInPhieuNhap != null)
                {
                    FindVatTuInPhieuNhap.SoLuongTon += chiTietPhieuNhap.SoLuongNhap;
                    ListChiTietPhieuNhap.Add(chiTietPhieuNhap);
                }
                else
                {
                    Console.WriteLine("Khong tim thay vat tu nay, ban phai nhap vat tu");
                    VatTu vatTu = new VatTu();
                    vatTu.InputDef();
                    dbContext.VatTu.Add(vatTu);
                    dbContext.SaveChanges();
                    chiTietPhieuNhap.VatTuId = vatTu.VatTuId;
                    ListChiTietPhieuNhap.Add(chiTietPhieuNhap);
                }

            }
            dbContext.ChiTietPhieuNhap.AddRange(ListChiTietPhieuNhap);
            dbContext.SaveChanges();
            return LogType.ThanhCong;
        }
        private LogType ThemPhieuXuat()
        {
            PhieuXuat phieuXuat = new PhieuXuat();
            phieuXuat.Input();
            dbContext.PhieuXuat.Add(phieuXuat);
            dbContext.SaveChanges();

            int SLChiTietPhieuXuat = InputHelper.InputInt("Nhap so luong chi tiet phieu xuat: ", "Vui long nhap vao la so!");
            var ListChiTietPhieuXuat = new List<ChiTietPhieuXuat>();

            for (int i = 0; i < SLChiTietPhieuXuat; i++)
            {
                ChiTietPhieuXuat chiTietPhieuXuat = new ChiTietPhieuXuat();
                chiTietPhieuXuat.Input(phieuXuat.PhieuXuatId);

                var FindVatTuInPhieuXuat = dbContext.VatTu.FirstOrDefault(x => x.VatTuId == chiTietPhieuXuat.VatTuId);
                if (FindVatTuInPhieuXuat == null) return LogType.KhongTimThayVatTu;
                if (FindVatTuInPhieuXuat.SoLuongTon == 0 && FindVatTuInPhieuXuat.SoLuongTon < chiTietPhieuXuat.SoLuongXuat) return LogType.SoLuongKhongDu;

                FindVatTuInPhieuXuat.SoLuongTon -= chiTietPhieuXuat.SoLuongXuat;
                ListChiTietPhieuXuat.Add(chiTietPhieuXuat);
            }
            dbContext.ChiTietPhieuXuat.AddRange(ListChiTietPhieuXuat);
            dbContext.SaveChanges();
            return LogType.ThanhCong;
        }
    }
}
