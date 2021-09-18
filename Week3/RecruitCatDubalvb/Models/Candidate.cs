using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatDubalvb.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public decimal TargetSalary { get; set; } 
        public DateTime OptionalStartDate { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public decimal? WorkExperience { get; set; }
        public bool ReadyToRelocate { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
