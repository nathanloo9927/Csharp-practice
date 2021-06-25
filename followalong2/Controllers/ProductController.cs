using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using followalong2.Models;
using followalong2.Services;
using Microsoft.AspNetCore.Mvc;

namespace followalong2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            HardCodedSampleDataRepository blah = new HardCodedSampleDataRepository();
            return View(blah.GetAllProducts());
        }
    }
}
