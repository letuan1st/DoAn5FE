using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models
{
    public class TLofPhimModel
    {
        [Key]
        public string MaPhim{get;set;}
        [Required]
        public string MaTheLoai{get;set;}
    }
}