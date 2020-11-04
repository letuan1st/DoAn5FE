using System;
using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models
{
    public class TapPhimModel
    {
        [Key]
        public string MaTapPhim{get;set;}
        [Required]
        public string TapSo{get;set;}
        [Required]
        public string Link{get;set;}
        public DateTime NgayDang{get;set;}
        
    }
}