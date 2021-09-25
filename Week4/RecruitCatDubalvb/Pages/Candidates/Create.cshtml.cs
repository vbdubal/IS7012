using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatDubalvb.Data;
using RecruitCatDubalvb.Models;

namespace RecruitCatDubalvb.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatDubalvb.Data.RecruitCatDubalvbContext _context;

        public CreateModel(RecruitCatDubalvb.Data.RecruitCatDubalvbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Id");
        ViewData["IndustryId"] = new SelectList(_context.Industry, "ID", "ID");
        ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
