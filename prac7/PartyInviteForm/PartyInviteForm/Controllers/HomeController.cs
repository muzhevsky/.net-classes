using PartyInviteForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInviteForm.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int day = DateTime.Now.DayOfYear;
            if (day > 350)
                ViewBag.Welcome = "С наступающим!!";

            if (day < 15)
                ViewBag.Welcome = "С наступившим!!";

            else
                ViewBag.Welcome = "Новый Год ещё не скоро";

            return View();
        }
    }
}