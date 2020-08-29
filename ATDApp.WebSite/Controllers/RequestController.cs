using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATDApp.WebSite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ATDApp.WebSite.Controllers
{

    [Route("api/Request")]
    [ApiController]
    public class RequestController : Controller
    {

        private readonly ApplicationDbContext _db;

        public RequestController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data =await _db.Request.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var requestFromDb = await _db.Request.FirstOrDefaultAsync(u => u.RequestId == id);
            if (requestFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }

            _db.Request.Remove(requestFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete succesful" }); 
        }



    }
}
