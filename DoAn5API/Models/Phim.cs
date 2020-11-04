using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn5API.Models
{
    public class Phim
    {
        [Key]
        public string MaPhim { get; set; }
        
        public string TenPhim { get; set; }
        public string SoTap { get; set; }
        public int Nam { get; set; }
        public string Anh { get; set; }
        public string NoiDung { get; set; }
        public int LuotXem { get; set; }
    }
}
