using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATDApp.WebSite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ATDApp.WebSite.Pages.RequestList
{
    public class EditModel : PageModel
    {

        private ApplicationDbContext _db;


        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }


        [BindProperty]
        public Request Request { get; set; }


        public async Task OnGet(int id)
        {
            Request = await _db.Request.FindAsync(id);
        }


        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var RequestFromDb = await _db.Request.FindAsync(Request.RequestId);
                RequestFromDb.RequestType = Request.RequestType;
                RequestFromDb.LocationID = Request.LocationID;
                RequestFromDb.FirstName = Request.FirstName;
                RequestFromDb.LastName = Request.LastName;
                RequestFromDb.Email = Request.Email;
                RequestFromDb.NumberRacksMarked = Request.NumberRacksMarked;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }

    }
}
