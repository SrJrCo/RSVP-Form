using System.ComponentModel.DataAnnotations;
namespace Belvis_Jonrae_HW1.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public String Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public String Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public Boolean? WillAttend { get; set; }
    }
}