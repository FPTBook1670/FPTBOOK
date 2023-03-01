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

    }
}
