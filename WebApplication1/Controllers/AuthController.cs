using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
    public class AuthController : BaseController
    {
        private readonly CarContext _context;

        public AuthController(CarContext context)
        {
            _context = context;
        }

        // GET: CarModel
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        // POST: Garage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Username, Password")] User user)
        {
            // Kiểm tra thông tin người dùng trong database
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(x => x.Username == user.Username && x.Password == user.Password);

            if (existingUser != null)
            {
                HttpContext.Session.SetString("LoggedInUser", existingUser.Username);
                // Chuyển hướng đến trang Index của controller Home
                return RedirectToAction("Index", "Home");
            }

            // Nếu đăng nhập không thành công, trả về trang Login với thông báo lỗi
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(user); // Hiển thị lại trang Login với thông tin đã nhập
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            // Xóa session của người dùng
            HttpContext.Session.Clear();

            // Chuyển hướng về trang đăng nhập hoặc trang chủ
            return RedirectToAction("Login", "Auth");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(
            [Bind("Id,Name,Email,Phone,Address,Username,Password,CreatedAt")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "Auth");
            }

            return View(user);
        }

        private bool GarageExists(int id)
        {
            return _context.Garages.Any(e => e.Id == id);
        }
    }
}