using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FPTBook.Models;
using FPTBook.Areas.Identity.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace FPTBook.Controllers
{
     [Authorize(Roles = "StoreOwner, Admin")]
    public class PublishersController : Controller
    {
        private readonly FPTBookIdentityDbContext _context;

        public PublishersController(FPTBookIdentityDbContext context)
        {
            _context = context;
        }
    }

    // GET: Publishers
        public async Task<IActionResult> Index()
        {
              return _context.Publisher != null ? 
                          View(await _context.Publisher.ToListAsync()) :
                          Problem("Entity set 'FPTBookContext.Publisher'  is null.");
        }

      // GET: Publishers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher
                .FirstOrDefaultAsync(m => m.Id == id);
            if (publisher == null)
            {
                return NotFound();
            }

            return View(publisher);
        }
}
