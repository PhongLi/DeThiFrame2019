using Microsoft.AspNetCore.Mvc;
using OnThi3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi3.Controllers
{
    public class CongViecController : Controller
    {
        public IActionResult ThemCV()
        {
            return View();
        }

        public string addCV(CongViecModel congViec)
        {
            int count;
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi3.Models.DataContext)) as DataContext;
            count = context.SqlAddCV(congViec);
            if (count == 1)
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
    }
}
