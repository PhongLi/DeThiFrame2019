using Microsoft.AspNetCore.Mvc;
using OnThi3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi3.Controllers
{
    public class BaoDuongController : Controller
    {
        public IActionResult LietKeTheoSXe()
        {
            return View();
        }

        public IActionResult ListBDtheoSXe(string SoXe)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi3.Models.DataContext)) as DataContext;
            return View(context.sqlListBDtheoSXe(SoXe));
        
        }
        public IActionResult ViewInfoBD(string MABD)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi3.Models.DataContext)) as DataContext;
            return View(context.sqlViewInfoBD(MABD));
        }


    }
}
