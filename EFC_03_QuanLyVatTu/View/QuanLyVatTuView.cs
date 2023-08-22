using EFC_03_QuanLyVatTu.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03_QuanLyVatTu.View
{
    public class QuanLyVatTuView
    {
        QuanLyVatTuController controller;

        public QuanLyVatTuView()
        {
            controller = new QuanLyVatTuController();
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------Menu----------");
                Console.WriteLine("1. Hien thi danh sach vat tu");
                Console.WriteLine("2. Hien thi danh sach vat tu can nhap them");
                Console.WriteLine("3. Them moi phieu nhap hoac xuat");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine();
                controller.ThucThi(c);
            }
        }
    }
}
