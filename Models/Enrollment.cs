using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SD1.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollnentID { get; set; }
        [Display(Name = "Student ID")]
        [Required(ErrorMessage = "Student ID is required")]
        public int StudentID { get; set; }
        [Display(Name = "Class ID")]
        [Required(ErrorMessage = "Class ID is required")]
        public int ClassID { get; set; }
        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }
    }
}