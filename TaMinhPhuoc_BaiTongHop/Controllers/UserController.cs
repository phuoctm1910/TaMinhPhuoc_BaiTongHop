using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaMinhPhuoc_BaiTongHop.Models;

namespace TaMinhPhuoc_BaiTongHop.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return Json(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                users.Add(user);
                return Json(new { success = true });
            }
            return BadRequest("Dữ liệu người dùng không hợp lệ.");
        }
    }
}
