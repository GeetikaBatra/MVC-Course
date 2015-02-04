using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidartionExample.Models
{
    public class User
    {
        [Required(ErrorMessage="UserNameRequired")]
        public string UserName { get; set; }
        public string Password{ get; set; }//Comparing Passwords with Confirm Password

        [Compare("Password")]
        [Required(ErrorMessage="Confirm Password required")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage="Qualification Required")]
        public string Qualification { get; set; }
        public string Gender { get; set; }
        public string CurrentCTC { get; set; }

        [Range(8,12)]
        public string ExpectedCTC { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Url]
        public string URL { get; set; }

    }
}