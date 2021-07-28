using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {

        [Required(ErrorMessage = "this field is required")]
        [StringLength(15, MinimumLength =5, ErrorMessage ="must be between 5 and 15 characters")]
        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "this field is required")]
        [StringLength(20,MinimumLength =6, ErrorMessage ="must be between 6 and 20 characters.")]
        [Compare("VerifyPassword", ErrorMessage ="Passwords must match.")]
        public string PassWord { get; set; }

        public DateTime DateJoined = DateTime.Now;

        [Required(ErrorMessage = "this field is required")]
        public string VerifyPassword { get; set; }




    }
}
