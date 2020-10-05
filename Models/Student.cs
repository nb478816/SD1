using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SD1.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20)]
        public string LastName { get; set; }
        [Display(Name = "Class")]
        [Required(ErrorMessage = "Classes are required")]
        [StringLength(20)]
        public ICollection<Class> Classes { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}