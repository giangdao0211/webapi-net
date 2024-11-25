using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(50)]
        public string TenLoai { get; set; }
    }
}
