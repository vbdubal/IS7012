﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatDubalvb.Data;
using RecruitCatDubalvb.Models;

namespace RecruitCatDubalvb.Pages.JobTitles
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
            return Page();
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JobTitle.Add(JobTitle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
