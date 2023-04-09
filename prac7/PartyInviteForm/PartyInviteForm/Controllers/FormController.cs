using PartyInviteForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInviteForm.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public ViewResult Form()
        {
            return View("Form");
        }

        [HttpPost]
        public ViewResult Form(PartyFormModel guest)
        {
            if (ModelState.IsValid)
                return View("../Result/Result", guest);

            return Form();
        }
    }
}