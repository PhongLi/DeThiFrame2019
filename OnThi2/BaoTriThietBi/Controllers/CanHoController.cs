using Microsoft.AspNetCore.Mvc;
using BaoTriThietBi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Controllers
{
    public class CanHoController : Controller
    {
        public IActionResult ThemCanHo()
        {
            return View();
        }
        [HttpPost]
        public String AddCH(CanHoModel canho)
        {
            int count;
            DataContext context = HttpContext.RequestServices.GetService(typeof(BaoTriThietBi.Models.DataContext)) as DataContext;
            count = context.SqlInsertCanHo(canho);
            if (count == 1)
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
    }
}
