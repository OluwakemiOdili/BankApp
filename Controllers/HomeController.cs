using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankApp.Models.DB_Model;
using BankApp.Models.View_Model;

namespace BankApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
         
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        [HttpPost]
        public ActionResult Register(NewCustomers newCustomer)
        {
            try
            {
                var db = new Model1();
                var cust = new Customer();
                cust.FirstName = newCustomer.FirstName;
                cust.LastName = newCustomer.LastName;
                cust.DOB = newCustomer.DOB;
                cust.RegistrationDate = DateTime.UtcNow.AddHours(1);
                db.Customers.Add(cust);
                db.SaveChanges();
                return RedirectToAction("Registration Successful");
            }
            catch (Exception Ex)
            {
                ViewBag.ErrorMessage = "...Registration failed";
                return View();
            }
        }
        public ActionResult SuccessfulReg()
        {
            return View();
        }


    }
}