using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KiaanSudyGroupInfo.Models
{
    public class MyClass
    {

        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }


        [Display(Name = "Email Adress")]
        public string Email { get; set; }

        [Display(Name = "Link")]
        public string myLink { get; set; }
    }
}