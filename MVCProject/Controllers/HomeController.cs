using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() {
        ViewBag.result = "Vui lòng nhập tham số trước!!";
        return View();
    }

    [HttpPost]
    public IActionResult Index(int a, int b, int c) {
        string resultStr = "";
        int delta = b * b - 4 * a * c;

        if (delta < 0) {
            resultStr = "Phương trình vừa nhập vô nghiệm";
        } else if (delta == 0) {
            double x = -b * 1.0 /2/a;
            resultStr = "Phương trình có nghiệm kép: " + x;
        } else {
            double x1 = ( -b - Math.Sqrt(delta)) / (2 * a);  
            double x2 = ( -b + Math.Sqrt(delta)) / (2 * a); 
            resultStr = "Phương trình có 2 nghiệm phân biệt: " + x1 + " và " + x2; 
        }
        ViewBag.result = resultStr;
        return View();
    }
}
