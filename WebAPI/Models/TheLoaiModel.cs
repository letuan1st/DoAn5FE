using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models
{
    public class TheLoaiModel
    {
        [Key]
        public string MaTheLoai{get;set;}
        [Required]
        public string TenTheLoai{get;set;}
    }
}