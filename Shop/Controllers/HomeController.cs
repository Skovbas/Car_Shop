using Microsoft.AspNetCore.Mvc;
using Shop.interfaces;
using Shop.ViewModels;
using System.Linq;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var viewModel = new HomeViewModel
            {
                favCars = _carRep.getFavCars.ToList()
            };

            return View(viewModel);
        }
    }
}
