using BusinessLayer;
using IBusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MetaGameStore.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUser _blUser;
        public UsersController(IUser bLUser)
        {
            _blUser = bLUser;
        }
        public IActionResult Index()
        {
            IEnumerable<User> usersList = _blUser.getUsers();
            return View(usersList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User model)
        {
            _blUser.add(model);
            return RedirectToAction("index");
        }
    }
}
