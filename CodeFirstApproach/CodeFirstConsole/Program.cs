using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstApproach;

namespace CodeFirstConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DepartmentContext())
            {
                Console.WriteLine("Add Department");
                var deptObj = new CodeFirst { DeptId = 1, Name = "HR", Location = "Pune" };
                dept.Departments.Add(deptObj);
                dept.SaveChanges();
                Console.WriteLine("Record entered");
            }
            Console.ReadLine();
        }
    }
}

