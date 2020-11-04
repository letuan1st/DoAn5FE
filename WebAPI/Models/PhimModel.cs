using System;
using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models
{
    public class PhimModel
    {
        [Key]
        public int MaPhim{get;set;}
        [Required]
        public string TenPhim{get;set;}
        [Required]
        public int SoTap{get;set;}
        public int Nam{get;set;}
        [Required]
        public string Anh{get;set;}
        [Required]
        public string NoiDung{get;set;}
        public int LuotXem{get;set;}

    }
}