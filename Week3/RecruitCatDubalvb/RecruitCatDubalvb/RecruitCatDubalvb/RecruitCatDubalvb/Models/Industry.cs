using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatDubalvb.Models
{
    public class Industry
    {
        public string Name { get; set; }
        public int ID { get; set; } 
        public int Revenue { get; set; }
        public List<Candidate> Candidates { get; set; }
        public int CandidatesId { get; set; }
        public List<Company> Companies { get; set; }
        public int CompaniesId { get; set; }
    }
}
