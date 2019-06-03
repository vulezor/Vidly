using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
			var customers = new List<Customer>
			{
					new Customer { Id=1, Name = "John Smit"},
					new Customer { Id=2, Name = "Mary Williams"},
			};
			var viewModel = new IndexCustomersViewModel
			{
				Customers = customers
			};
			return View(viewModel);
        }


		[Route("customers/list/{id}")]
		public ActionResult Detail(int id)
		{
			
			return Content("ID="+ id);
		}
		
	}
}