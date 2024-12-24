using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
    public class NganhHoc
    {
        [Key]
        [StringLength(4)]
        public string MaNganh { get; set; }

        [Required]
        [StringLength(30)]
        public string TenNganh { get; set; }
    }
}
