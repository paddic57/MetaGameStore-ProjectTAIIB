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
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            _blUser.delete(id);
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("Index");
        }
        public ActionResult Detail(int id)
        { 
            var data = _blUser.getByUserId(id);
            return View("Details", data);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _blUser.getByUserId(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(User model)
        {
            var data = _blUser.getByUserId(model.Id);
            _blUser.update(data);
            return RedirectToAction("Index");
        }
    }
}
