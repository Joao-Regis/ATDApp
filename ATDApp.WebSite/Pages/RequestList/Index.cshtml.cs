using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATDApp.WebSite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ATDApp.WebSite.Pages.RequestList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;


        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }


        public IEnumerable<Request> Requests { get; set; }


        public async Task OnGet()
        {
            Requests = await _db.Request.ToListAsync();

        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var request = await _db.Request.FindAsync(id);
            if(request == null)
            {
                return NotFound();
            }
            _db.Request.Remove(request);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        //test01 test02 test03
    }
}
