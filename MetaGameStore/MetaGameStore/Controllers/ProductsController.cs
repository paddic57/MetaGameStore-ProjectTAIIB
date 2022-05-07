using BusinessLayer;
using IBusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MetaGameStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProduct _blProduct;

        public ProductsController(IProduct blProduct)
        {
            _blProduct = blProduct;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> productsList = _blProduct.getProducts();
            return View(productsList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product model)
        {
            _blProduct.add(model);
            return RedirectToAction("index");
        }
        public ActionResult Delete(int id)
        {
            //_blProduct.delete(id)
            ViewBag.Messsage = "Record Delete Successfully";
            return RedirectToAction("index");
        }
        public ActionResult Detail(int id)
        {
            var data = _blProduct.getByProductId(id);
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _blProduct.getByProductId(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Product model)
        {
            var data = _blProduct.getByProductId(model.Id);
            _blProduct.update(data);
            return RedirectToAction("index");
        }

    }
}
