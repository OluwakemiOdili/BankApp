using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankApp.Controllers
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public  DateTime DOB { get; set; }
        public DateTime RegistrationDate { get; set; }  
    }
}