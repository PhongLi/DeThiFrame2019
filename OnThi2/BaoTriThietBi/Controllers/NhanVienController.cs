using Microsoft.AspNetCore.Mvc;
using BaoTriThietBi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Controllers
{
    public class NhanVienController : Controller
    {
        public IActionResult LietKeNVtheoSoLan()
        {
            return View();
        }

        public IActionResult Listbytime(int solan)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(BaoTriThietBi.Models.DataContext)) as DataContext;
            return View(context.sqlListByTimeNhanVien(solan));
        }

        public IActionResult LietKeNV()
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(BaoTriThietBi.Models.DataContext)) as DataContext;
            return View(context.sqlLietKeNV());
        }


    }
}
