using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{
    [Table("Sach")]
    public class Sach
    {
        [Key]
        public int Id { get; set; }
        public int ChieuDai { get; set; }
        public int ChieuRong { get; set; }

        public int ChuDeId { get; set; }
        public int DanhMucId { get; set; }
        public string DinhDang { get; set; }
        public int DonGia { get; set; }
        public string HinhAnh { get; set; }
        public int NhaXuatBanId { get; set; }
        public int PhanTramGiamGia { get; set; }
        public int SoLuong { get; set; }
        public int SoTrang { get; set; }
        public int TacGiaId { get; set; }
        public string TenSach { get; set; }
        public string TomTat { get; set; }
    }
}