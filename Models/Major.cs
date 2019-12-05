using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Directory.Models {

    public class Major {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Major ID")]
        [Required(ErrorMessage = "{0} Is required.")]
        public int Major_Num { get; set; }

        [Display(Name = "Major")]
        [Required(ErrorMessage = "{0} Is required.")]
        public string Major_Id { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "{0} Is required.")]
        public string Major_Dept { get; set; }

        [Display(Name = "Description")]
        public string Major_Desc { get; set; }

        [Display(Name = "Degree")]
        public string Major_Degree { get; set; }

    }
}