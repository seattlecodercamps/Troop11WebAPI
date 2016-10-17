using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MegaTron.Models;
using MegaTron.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MegaTron.API
{
    [Route("api/[controller]")]
    public class MakesController : Controller
    {
        private CarService _carService;

        public MakesController(CarService carService)
        {
            _carService = carService;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<CarMake> Get()
        {
            return _carService.ListMakes();
        }


    }
}
