using Classwork._26._10._23.Models;
using Classwork._26._10._23.Services.Abstract;
using Classwork._26._10._23.Services.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Classwork._26._10._23.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAppDataContext _dataContext;
        //private readonly List<CarModel> _carmodel;
        //private readonly List<Car> _car;
        public HomeController(IAppDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
            {
                return View(_dataContext.Marka);
            }
            //_carmodel = new List<CarModel>
            //{
            //    new CarModel{Name="A1"},
            //    new CarModel{Name="F800"},
            //    new CarModel{Name="Neon"},
            //    new CarModel{Name="Sentra"},
            //    new CarModel{Name="S500"},
            //    new CarModel{Name="XC40"},

            //};
            //_car = new List<Car>
            //{
            //    new Car{Name="Audi A1"},
            //    new Car{Name="BMW F800"},
            //    new Car{Name="Chryseler Neon"},
            //    new Car{Name="Nissan Sentra"},
            //    new Car{Name="Mercedes S500"},
            //    new Car{Name="Volvo XC40"},
            //};
        
        //public IActionResult Index()
        //{
        //    return View(_marka);
        //}
        //public IActionResult CarModel(int? id)
        //{
        //    if (id == null) return BadRequest();
        //    Marka? marka = _marka.Find(m=>m.Id==id);
        //    if (marka == null) return NotFound();
        //    return View(marka);
        //}

    }
}

