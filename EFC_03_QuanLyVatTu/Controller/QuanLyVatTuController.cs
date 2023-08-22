using EFC_03_QuanLyVatTu.Helper;
using EFC_03_QuanLyVatTu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03_QuanLyVatTu.Controller
{
    public class QuanLyVatTuController
    {
        QuanLyVatTuServices services;

        public QuanLyVatTuController()
        {
            services = new QuanLyVatTuServices();
        }
        public void ThucThi(char c)
        {
            switch (c)
            {
                case '1':
                    LogHelper.QuanLyVatTuLog(services.HienThiDanhSachVatTu());
                    break;
                case '2':
                    LogHelper.QuanLyVatTuLog(services.HienThiVatTuCanThem());
                    break;
                case '3':
                    LogHelper.QuanLyVatTuLog(services.ThemMoiPhieuNhapHoacXuat());
                    break;
                case '4':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Khong co chuc nang nay, vui long nhap lai!");
                    break;
            }
            Console.WriteLine("\nNhan phim bat ky de tiep tuc!");
            Console.ReadKey();
        }
    }
}
