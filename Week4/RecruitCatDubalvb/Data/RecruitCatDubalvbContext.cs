using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatDubalvb.Models;

namespace RecruitCatDubalvb.Data
{
    public class RecruitCatDubalvbContext : DbContext
    {
        public RecruitCatDubalvbContext (DbContextOptions<RecruitCatDubalvbContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatDubalvb.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatDubalvb.Models.Company> Company { get; set; }

        public DbSet<RecruitCatDubalvb.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatDubalvb.Models.JobTitle> JobTitle { get; set; }
    }
}
