using Microsoft.AspNetCore.Mvc;
using OnThi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Controllers
{
    public class DiemCachLyController : Controller
    {
        public IActionResult ThemDCL()
        {
            return View();
        }

        [HttpPost]
        public string AddDCL(DiemCachLyModel dcl)
        {
            int count;
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi.Models.DataContext)) as DataContext;
            count = context.sqlInsertDCL(dcl);
            if (count == 1)
            {
                return "Thêm Thành Công!";
            }
            return "Thêm thất bại";
        }

        public IActionResult ListDCL()
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(DataContext)) as DataContext;
            return View(context.sqlListDCL());
        }
    }
}
