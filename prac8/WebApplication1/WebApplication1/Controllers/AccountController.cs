using Application.Models;
using Application.Utils;
using Application.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class AccountController : Controller
    {
        FormAuthenticationManager _authenticationManager;
        public AccountController(FormAuthenticationManager manager)
        {
            _authenticationManager = manager;
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View("Login", new LoginForm());
        }

        [HttpPost]
        public ActionResult Login(LoginForm form, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (_authenticationManager.Authenticate(form.UserName, form.Password))
                    return Redirect(returnUrl ?? Url.Action("Admin", "Admin"));

                ModelState.AddModelError("", "Неправильный логин или пароль");
                return View();
            }

            return View();
        }
    }
}