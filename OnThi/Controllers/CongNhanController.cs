using OnThi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Controllers
{
    public class CongNhanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListCNByNum(int soTC)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(DataContext)) as DataContext;
            return View(context.sqlListCNbyNum(soTC));
        }

        public IActionResult LietKeCNtheoDCL(string madiemcachly)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(DataContext)) as DataContext;
            return View( context.sqlLietKeCNtheoDCL(madiemcachly));
        }

    }
}
