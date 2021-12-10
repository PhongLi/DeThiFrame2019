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
        public IActionResult LietKeCNtheoSoLan()
        {
            return View();
        }
        public IActionResult ListCNByNum(int soTC)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(DataContext)) as DataContext;
            return View(context.sqlListCNbyNum(soTC));
        }

    }
}
