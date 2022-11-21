using CRMUpSchool.DataAccessLayer.Concrete;
using CRMUpSchool.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpSchoolCRM.UILayer.Models;

namespace UpSchoolCRM.UILayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(AppUser appUser)
        {
            //aynı anda birden fazla işlem gerçekleştirilmesi async metodta async olması laızm
            var result = await _userManager.CreateAsync(appUser, appUser.PasswordHash);
            if (result.Succeeded) 
            {
                return RedirectToAction("Index", "UserList");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index2(UserSignUpModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = p.Username,
                    Surname = p.Surname,
                    Email = p.Email,
                    PhoneNumber = p.Phonenumber
                };
                if (p.Password == p.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(appUser, p.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");

                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }

                    }
                }
                else
                {
                    ModelState.AddModelError("", "Şifreler uyuşmuyor");
                }
            }

            return View();
        }
    }
}
