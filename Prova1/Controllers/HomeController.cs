using Microsoft.AspNetCore.Mvc;
using MyPizzeriaModel.Models;
using System.Diagnostics;


namespace MyPizzeriaModel.Controllers
    {
    public class HomeController : Controller
        {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
            {
            _logger = logger;
            }

        public IActionResult Index()
            {
            using PizzaContext db = new PizzaContext();
            List<Pizza> listaPizze = db.Pizzas.ToList();
            return View(listaPizze);
            }

        public IActionResult Dettagli(int id)
            {
            using PizzaContext db = new PizzaContext();
            Pizza pizza = (from p in db.Pizzas where p.Id == id select p).FirstOrDefault();
            if (pizza == null)
                {
                return NotFound();
                }
            else
                {
                return View(pizza);
                }
            }
        [HttpGet]
        public IActionResult FormAddPizza()
            {
            return View("FormPizza"); 
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FormAddPizza(Pizza formData) 
            {
            if (!ModelState.IsValid) 
                {
                return View("FormPizza");
                }
            using PizzaContext db = new PizzaContext();
            db.Pizzas.Add(formData);
            db.SaveChanges();
            return RedirectToAction("Index");
            }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }


        }
    }