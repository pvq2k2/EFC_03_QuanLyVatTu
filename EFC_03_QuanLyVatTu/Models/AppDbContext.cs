using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03_QuanLyVatTu.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<VatTu> VatTu { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
        public DbSet<ChiTietPhieuXuat> ChiTietPhieuXuat { get; set; }
        public DbSet<PhieuNhap> PhieuNhap { get; set; }
        public DbSet<PhieuXuat> PhieuXuat { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server = DESKTOP-O1GKQUN; Database = QuanLyVatTu; Trusted_Connection = True; TrustServerCertificate = True");
        }
    }
}
