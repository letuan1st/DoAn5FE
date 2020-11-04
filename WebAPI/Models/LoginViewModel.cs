using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name="User Name")]
        public string UserName{get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string PassWord{get;set;}
    }
}