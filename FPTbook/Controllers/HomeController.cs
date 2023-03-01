using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FPTBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using FPTBook.Utils;
using FPTBook.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FPTBook.Controllers;

public class HomeController : Controller
{
    private readonly FPTBookIdentityDbContext _context;
    private readonly UserManager<BookUser> _userManager;

    public HomeController(FPTBookIdentityDbContext context, UserManager<BookUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    // public IActionResult Index()
    // {
    //     return View();
    // }


   
}
