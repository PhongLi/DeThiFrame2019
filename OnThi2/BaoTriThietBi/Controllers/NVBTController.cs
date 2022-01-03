using Microsoft.AspNetCore.Mvc;
using BaoTriThietBi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnThi.Controllers
{
    public class NVBTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LietKeTBtheoNV(string MaNhanVien)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(BaoTriThietBi.Models.DataContext)) as DataContext;
            return View(context.sqlGetNVBT(MaNhanVien));

        }
        
        public IActionResult DeleteThietBi(string MaNV, int LanThu)
        {
            
            DataContext context = HttpContext.RequestServices.GetService(typeof(BaoTriThietBi.Models.DataContext)) as DataContext;
            int count = context.XoaTB(MaNV, LanThu);
            if (count > 0)
                ViewData["thongbao"] = "Xóa thành công";
            else
                ViewData["thongbao"] = "Xóa không thành công";
            return View();
        }
        public IActionResult ViewThietBi(string MaNV, int LanThu)
        {

            DataContext context = HttpContext.RequestServices.GetService(typeof(BaoTriThietBi.Models.DataContext)) as DataContext;
            return View(context.sqlViewThietBi(MaNV, LanThu));
        }
    }
}
