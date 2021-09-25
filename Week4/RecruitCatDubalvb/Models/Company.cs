using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;




namespace RecruitCatDubalvb.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required] 
        [StringLength(50)]
        public string Name { get; set; }


        [Required]
        [StringLength(100)]
        public string Location { get; set; }


        [DisplayName("Position Start Date")]
        [DataType(DataType.Date)]
        public DateTime Optionalstartdate { get; set; }


        [DisplayName("Minimum Salary")]
        [Range(0, 100000000)]
        public decimal MiniSalary { get; set; }


        [DisplayName("Maximum Salary")]
        [Range(0, 100000000)]
        public decimal MaxSalary { get; set; }


        [DisplayName("Position Name")]
        [Required]
        [StringLength(50)]
        public string PositionName { get; set; }


        [DisplayName("Employee Count")]
        [Range(0, 100000000)]
        public int EmployeeCount { get; set; }


        [DisplayName("Company Start Date")]
        [DataType(DataType.Date)]
        public DateTime CompanyStart { get; set; }


        [DisplayName("Candidate")]
        public List<Candidate> Candidates { get; set; }
        
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
        public JobTitle Jobtitle { get; set; }
        public int JobtitleId { get; set; }
    }
}
