using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace RecruitCatDubalvb.Models
{
    public class Industry
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int ID { get; set; }

        [Range(0, 10)]
        [DisplayName("Revenue")]
        public int Revenue { get; set; }

     
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
        
    }
}
