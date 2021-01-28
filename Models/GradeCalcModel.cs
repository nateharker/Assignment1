using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class GradeCalcModel
    {
        [Required]
        [Range(0, 100)] /*to ensure numbers are between 0 and 100*/
        public int assignments { get; set; }
        [Required]
        [Range(0, 100)]
        public int groupProject { get; set; }
        [Required]
        [Range(0, 100)]
        public int quizzes { get; set; }
        [Required]
        [Range(0, 100)]
        public int exams { get; set; }
        [Required]
        [Range(0, 100)]
        public int intex { get; set; }
    }
}
