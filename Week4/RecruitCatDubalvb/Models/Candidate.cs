
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatDubalvb.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        
        [DisplayName("Target Salary")]
        [Range(0, 100000000)]
        public decimal TargetSalary { get; set; }


        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }


        [DisplayName("First Name")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }


        [DisplayName("Last Name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }


        [DisplayName("Work Experience")]
        [Range(0, 30)]
        public decimal? WorkExperience { get; set; }


        [DisplayName("Ready for Relocation")]
        public bool ReadyToRelocate { get; set; }


        [DisplayName("Company")]
        public Company Company { get; set; }
        [DisplayName("Company")]
        public int? CompanyId { get; set; }

        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }

        [DisplayName("Industry")]
        public Industry Industry { get; set; }
        [DisplayName("Industry")]
        public int IndustryId { get; set; }
    }
}
