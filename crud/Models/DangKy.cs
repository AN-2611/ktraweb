
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using crud.Models;
namespace crud
{
    public class DangKy
    {
        [Key]
        public int MaDK { get; set; }

        [Column(TypeName = "Date")]
        public DateTime NgayDK { get; set; }

        [ForeignKey("SinhVien")]
        public string MaSV { get; set; }
        public virtual SinhVien SinhVien { get; set; }

        // Khởi tạo List để tránh null
        public List<ChiTietDangKy> ChiTietDangKys { get; set; } = new List<ChiTietDangKy>();
    }
}
