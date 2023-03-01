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

    public IActionResult Index()
        {
            return View();
        }

     public IActionResult ManageUser()
    
    {
        return View();
    }
     public IActionResult ManageCategory()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

     public IActionResult ReportDemo()
        {
            var data = _context.OrderItem.Include(s => s.Book)
                        .GroupBy(s => s.Book.Title)
                        .Select(g => new { Title = g.Key, Total = g.Sum(s => s.Quantity*s.Book.Price), TotalQuantity= g.Sum(s => s.Quantity)})
                        .ToList();

            string[] labels = new string[data.Count];
            string[] totalquantity = new string[data.Count];
            string[] totals = new string[data.Count];


            for (int i = 0; i < data.Count; i++)
            {
                labels[i] = data[i].Title;
                totalquantity[i] = data[i].TotalQuantity.ToString();
                totals[i] = data[i].Total.ToString();

            }

            ViewData["labels"] = string.Format("'{0}'", String.Join("','", labels));
            ViewData["totalquantity"] = String.Join(",", totalquantity);
            ViewData["totals"] = String.Join(",", totals);

            return View(data);
        }

   

}