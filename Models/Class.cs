using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SD1.Models
{
    public class Class
    {
        public int ClassID { get; set; }
        [Display(Name = "Class Name")]
        [Required(ErrorMessage ="Class Name is required")]
        [StringLength(20)]
        public string ClassName { get; set; }
        [Display(Name = "Class Description")]
        public string ClassDescription { get; set; }
        [Display(Name = "Professor ID")]
        public  int professorID { get; set; }
        [Display(Name = "Date Time ID")]
        public int dateTimeID { get; set; }
        public virtual Student Students { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}