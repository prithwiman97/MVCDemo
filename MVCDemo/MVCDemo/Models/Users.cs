using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Users
    {
        public int Id { get; set; }

        [Display(Name ="Full Name")]
        [Required]
        public string Name { get; set; }
        public string Password { get; set; }
    }
}