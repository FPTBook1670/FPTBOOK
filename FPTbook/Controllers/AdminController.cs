using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FPTBook.Models;
using FPTBook.Areas.Identity.Data;

using System.Linq;
using System.Threading.Tasks;

using OfficeOpenXml;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;


namespace FPTBook.Controllers;
[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    // private readonly ILogger<AdminController> _logger;
    
    // public AdminController(ILogger<AdminController> logger)
    // {
    //     _logger = logger;
    // }

    private readonly FPTBookIdentityDbContext _context;
    private readonly IWebHostEnvironment hostEnvironment;

    public AdminController(FPTBookIdentityDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            hostEnvironment = environment;
        }


   

}