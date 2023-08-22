using EFC_03_QuanLyVatTu.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03_QuanLyVatTu.Helper
{
    public enum LogType
    {
        Thoat, KhongTimThayVatTu, SoLuongKhongDu, DanhSachTrong, ThanhCong
    }
    internal class LogHelper
    {
        public static void QuanLyVatTuLog(LogType log)
        {
            switch (log)
            {
                case LogType.ThanhCong:
                    Console.WriteLine(QuanLyVatTuRes.LogThanhCong);
                    break;
                case LogType.DanhSachTrong:
                    Console.WriteLine(QuanLyVatTuRes.LogDanhSachTrong);
                    break;
                case LogType.KhongTimThayVatTu:
                    Console.WriteLine(QuanLyVatTuRes.LogKhongTimThayVatTu);
                    break;
                case LogType.SoLuongKhongDu:
                    Console.WriteLine(QuanLyVatTuRes.LogSoLuongKhongDu);
                    break;
            }
        }
    }
}
