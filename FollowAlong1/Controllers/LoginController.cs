using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SideProject.Models;
using SideProject.Services;

namespace SideProject.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel user)
        {
            SecurityService secService = new SecurityService();
            if (secService.isValid(user))
            {
                return View("LoginSuccess", user);
            } else
            {
                return View("LoginFailure", user);
            }
        }
    }
}
