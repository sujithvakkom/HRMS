using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class UserLoginModel
    {
        [Display(Name ="User Name")]
        [Required(ErrorMessage ="User name is required field.")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please Enter a valid Email.")]
        public String UserName { get; set; }

        [Display(Name ="Password")]
        [Required(ErrorMessage ="Password is required field.")]
        public String Password { get; set; }
    }
}