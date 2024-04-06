using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core.UI.ConvertTableGridIntoDataSetScroll.Controllers
{
    public class PizzaStoreController : Controller
    {
        private readonly IPizzaServices _pizzaServices;
        public PizzaStoreController(IPizzaServices pizzaServices) 
        {
            _pizzaServices = pizzaServices;
        }
        // GET: PizzaStoreController
        public ActionResult Index()
        {
            return View(_pizzaServices.GetAll().AsEnumerable());
        }

        // GET: PizzaStoreController/Details/5
        public ActionResult Details(int id)
        {
            return View(_pizzaServices.Get(id));
        }

        // GET: PizzaStoreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaStoreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaStoreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaStoreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaStoreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaStoreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
