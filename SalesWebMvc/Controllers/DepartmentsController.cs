using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department() { Id = 1, Name = "Eletronics" });
            list.Add(new Department() { Id = 2, Name = "Fashion" });
            return View(list);
        }

        public IActionResult Create()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Edit()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Details()
        {
            throw new System.NotImplementedException();
        }

        public IActionResult Delete()
        {
            throw new System.NotImplementedException();
        }
    }
}