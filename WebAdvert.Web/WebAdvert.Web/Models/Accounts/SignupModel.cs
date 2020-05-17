using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class SignupModel
    {
        [Requered]
        [EmailAddress]
        [Display(Name="Email")]
        public string Email { get; set; }

        [Requered]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage = "Password must be at least six characters long!")]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Requered]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirmation do not match")]
        public string ConfirmPassword { get; set; }
    }
}
