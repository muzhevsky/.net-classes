using PartyInviteForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInviteForm.Controllers
{
    public class AdminController : Controller
    {

        [HttpGet]
        public ViewResult Admin()
        {
            return View("Admin", new ParticipantListModel());
        }
    }
}