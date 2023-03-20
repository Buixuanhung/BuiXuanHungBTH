using Microsoft.AspNetCore.Mvc;

namespace BuiXuanHungBTH.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index(string FullName)
        {
            string strReturn = "Hello " + FullName;
            //gui du lieu ve view
            ViewBag.thongbao = strReturn;
            return View();
            //tra ve danh sach cac sinh vien trong Database
        }
         public IActionResult About()
        {
            return View();
        }
    }
}