using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatDubalvb.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Domain { get; set; }


        [DisplayName("Minimum   Salary")]
        [Range(0, 100000000)]
        public decimal MiniSalary { get; set; }


        [DisplayName("Maximum Salary")]
        [Range(0, 100000000)]
        public decimal MaxSalary { get; set; }


        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
