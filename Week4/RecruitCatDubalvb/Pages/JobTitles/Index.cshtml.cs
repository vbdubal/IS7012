using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatDubalvb.Data;
using RecruitCatDubalvb.Models;

namespace RecruitCatDubalvb.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatDubalvb.Data.RecruitCatDubalvbContext _context;

        public IndexModel(RecruitCatDubalvb.Data.RecruitCatDubalvbContext context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get;set; }

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle.ToListAsync();
        }
    }
}
