using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class ConfirmModel
    {
        [Requered]
        [Display(Name="Email")]
        [EmailAddress]
        [Required(ErrorMessage = "Email is Required.")]
        public string Email { get; set; }
        [Required(ErrorMessage="Code is Required.")]
        public string Code { get; set; }
    }
}
