using EFC_03_QuanLyVatTu.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03_QuanLyVatTu.IServices
{
    public interface IQuanLyVatTuServices
    {
        LogType HienThiDanhSachVatTu();
        LogType HienThiVatTuCanThem();
        LogType ThemMoiPhieuNhapHoacXuat();
    }
}
