﻿using MvcFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFirstApp.Controllers
{
    public class EmployeeController : Controller
    {

        //public static List<Employee> empList = new List<Employee>
        //{

        //        new Employee {
        //            ID = 1,
        //            Name = "Sneha",
        //            JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
        //            Age = 21
        //        },

        //        new Employee {
        //            ID = 2,
        //            Name = "Jack",
        //            JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
        //            Age = 23
        //        },

        //        new Employee {
        //            ID = 3,
        //            Name = "Komal",
        //            JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
        //            Age = 21
        //        },

        //        new Employee {
        //            ID = 4,
        //            Name = "Pia",
        //            JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
        //            Age = 22
        //        },
        //};

        private EmpDBContext db = new EmpDBContext();

        // GET: Employee
        public ActionResult Index()
        {
            var employees = from e in db.Employees
                            orderby e.ID
                            select e;

            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                // TODO: Add insert logic here
                //Employee emp = new Employee();

                //emp.Name = collection["Name"];
                //DateTime jDate;
                //DateTime.TryParse(collection["DOB"], out jDate);
                //emp.JoiningDate = jDate;
                //string age = collection["Age"];
                //emp.Age = Int32.Parse(age);

                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            //List<Employee> empList = GetEmployeeList();
            var employee = db.Employees.Single(m => m.ID == id);
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var employee = db.Employees.Single(m => m.ID == id);
                if(TryUpdateModel(employee))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
