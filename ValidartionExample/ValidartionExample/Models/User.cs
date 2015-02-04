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
        public string Password{ get; set; }
        public string ConfirmPassword { get; set; }
        public string Qualification { get; set; }
        public string Gender { get; set; }
        public string CurrentCTC { get; set; }
        public string ExpectedCTC { get; set; }
        public string Email { get; set; }
        public string URL { get; set; }

    }
}