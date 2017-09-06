using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge6
{
    class employee
    {
        public int empID;
        public string eName;
        public string deptName;
        public string projectName;

        public void employyeFunction()
        {
            List<employee> employeeList = new List<employee>();
            employeeList.Add(new employee { empID = 0913, eName= "Sneha", deptName = "Development", projectName = "C#" });
            employeeList.Add(new employee { empID = 1309, eName = "Jill", deptName = "Testing", projectName = "C#" });
            employeeList.Add(new employee { empID = 1234, eName = "Pooja", deptName = "Development", projectName = "Java" });
            employeeList.Add(new employee { empID = 7654, eName = "Kittu", deptName = "Testing", projectName = "Java" });
            employeeList.Add(new employee { empID = 7645, eName = "Komal", deptName = "Development", projectName = "C#" });

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("Retrieving Top 2 people from the list whose department name is development\n");
            foreach (employee emp in employeeList.FindAll(e => (e.deptName == "Development")).Take(2).ToList())
            {
                Console.WriteLine("Name : " + emp.eName + " \t\tDept: " + emp.deptName);
            }

            Console.WriteLine("\nEmployees in dept Testing and project name C#");
            if (employeeList.Any(e => (e.deptName == "Testing" && e.projectName == "C#")))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine("\nChecking whether a person having name 'Sneha' exists or not...");
            if (employeeList.Exists(e => e.eName == "Sneha"))
            {
                Console.WriteLine("Yes, A person having name  'Sneha' exists in our list");
            }

            Console.WriteLine("\nChecking the index position of a person having name 'Komal' ...");
            int indexForKomal = employeeList.FindIndex(e => e.eName == "Komal");
            Console.WriteLine("In the list, The index position of a person having name 'Komal' is : " + indexForKomal);

            employee p = employeeList.First(m => m.empID == (employeeList.Max(e => e.empID)));
            Console.WriteLine("\n\nThe most aged person in our list is: " + p.eName + " whose Emp ID is: " + p.empID);

            foreach (employee emp in employeeList.SkipWhile(e => e.empID < 1234))
            {
                Console.WriteLine("Name : " + emp.eName + " \t\tAge: " + emp.empID);
            }



        }

    }
}
