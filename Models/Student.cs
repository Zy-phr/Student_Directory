using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Directory.Models {

    public class Student {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student ID")]
        [Required(ErrorMessage = "{0} Is required.")]
        public int Student_Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "{0} Is required.")]
        public string First_Name { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "{0} Is required.")]
        public string Last_Name { get; set; }

        [Display(Name = "Date of Birth")]
        public string Date_of_Birth { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Major")]
        [Required(ErrorMessage = "{0} Is required.")]
        public string Major_Id { get; set; }


    }
}