using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using ATDApp.WebSite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATDApp.WebSite.Pages.RequestList
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Request Request { get; set; }



        public void OnGet()
        {


        }


        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.Request.AddAsync(Request);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");

            }
            else
            {
                return Page();
            }

        }

    }
}
