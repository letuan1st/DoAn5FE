using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name="User Name")]
        public string UserName{get;set;}
        [Required]
        [DataType(DataType.Password)]
        public string PassWord{get;set;}
        [Required]
        [EmailAddress]
        public string Email{get;set;}
    }
}