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
    public class CategoriesController : Controller
    {
        private readonly FPTBookIdentityDbContext _context;

        public CategoriesController(FPTBookIdentityDbContext context)
        {
            _context = context;
        }

         // GET: Categories
        [Authorize(Roles = "StoreOwner, Admin")]
        public async Task<IActionResult> Index()
        {
              return _context.Category != null ? 
                          View(await _context.Category.ToListAsync()) :
                          Problem("Entity set 'FPTBookContext.Category'  is null.");
        }

        [Authorize(Roles = "StoreOwner, Admin")]
        public async Task<IActionResult> RequestCategory()
        {
              return View(await _context.Category.ToListAsync());
        }

    }
}
