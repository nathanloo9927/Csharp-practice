using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using followalong4.Models;
using Microsoft.AspNetCore.Mvc;

namespace followalong4.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();
        public CustomerController()
        {
            customers.Add(new CustomerModel { Id = 0, Name = "Milk Bear", Age = 20 });
            customers.Add(new CustomerModel { Id = 1, Name = "Mocha Bear", Age = 22 });
            customers.Add(new CustomerModel { Id = 2, Name = "Tenko", Age = 17 });
            customers.Add(new CustomerModel { Id = 3, Name = "Himiko", Age = 17 });
            customers.Add(new CustomerModel { Id = 4, Name = "Maki", Age = 17 });
            customers.Add(new CustomerModel { Id = 5, Name = "Shuichi", Age = 17 });
            customers.Add(new CustomerModel { Id = 6, Name = "Kaito", Age = 17 });
            customers.Add(new CustomerModel { Id = 7, Name = "K1-B0", Age = 37 });
        }
        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult ShowOnePerson(int id)
        {
            CustomerModel c = customers.FirstOrDefault(x => x.Id == id);
            return PartialView(c);
        }
    }
}
