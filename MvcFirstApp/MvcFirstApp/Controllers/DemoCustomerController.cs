using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFirstApp.Controllers
{
    public class DemoCustomerController : Controller
    {
        // GET: Customer
        //[ActionName("AllCustomers")]
        public string GetAllCustomers()
        {
            return @"<ul>
                <li>Sneha Kewlani</li>
                <li>Kirti Phuge</li>
                <li>Pooja Newase</li>
                <li>Sneha Kewlani</li>
            </ul>";
        }
    }
}