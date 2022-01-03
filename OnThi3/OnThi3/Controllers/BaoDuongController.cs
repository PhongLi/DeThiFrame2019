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
        public IActionResult EditInfoBD(string MABD)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi3.Models.DataContext)) as DataContext;
            return View(context.sqlEditInfoBD(MABD));
        }

        public IActionResult DeleteCTBD(string MABD, string MACV)
        {
            DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi3.Models.DataContext)) as DataContext;
            context.sqlDeleteCTBD(MABD, MACV);
            return RedirectToAction("LietKeTheoSXe");
        }
            public IActionResult updateBD(string MABD, string Ngaygiotra)
            {
                DataContext context = HttpContext.RequestServices.GetService(typeof(OnThi3.Models.DataContext)) as DataContext;
            context.sqlupdateBD(MABD, Ngaygiotra);
            return RedirectToAction("LietKeTheoSXe");

        }


        }
}
