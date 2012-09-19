using InoutBoard.Core.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InoutBoard.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepo;

        public HomeController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public ActionResult Index()
        {
            var users = _userRepo.GetAll();
            return View(users);
        }
    }
}
