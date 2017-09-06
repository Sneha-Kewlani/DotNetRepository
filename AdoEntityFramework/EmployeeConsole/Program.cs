using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoEntityFramework;

namespace EmployeeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var EmpObj = new EmployeesEntities())
            {
                /*var emp1 = new Emp();
                emp1.EmpId = 1;
                emp1.Name = "Sneha";
                emp1.Salary = 30000;
                EmpObj.Emps.Add(emp1);

                var emp2 = new Emp();
                emp2.EmpId = 2;
                emp2.Name = "Pooja";
                emp2.Salary = 30000;
                EmpObj.Emps.Add(emp2);

                var emp3 = new Emp();
                emp3.EmpId = 3;
                emp3.Name = "Kittu";
                emp3.Salary = 30000;
                EmpObj.Emps.Add(emp3);
                EmpObj.SaveChanges();*/

                //update
                //Emp emp1Obj = EmpObj.Emps.First(i => i.EmpId == 2);
                //emp1Obj.Name = "Pooja N";
                //emp1Obj.Salary = 20000;
               
                //EmpObj.SaveChanges();

               /* var emp4 = new Emp();
                emp4.EmpId = 4;
                emp4.Name = "abcd";
                emp4.Salary = 30000;
                EmpObj.Emps.Add(emp4);
                EmpObj.SaveChanges();*/

                //delete
                 //Emp emp2Obj = EmpObj.Emps.First(i => i.EmpId == 4);
                 //EmpObj.Emps.Remove(emp2Obj);
                 //EmpObj.SaveChanges();

                


                Console.WriteLine("Entries added in table");
                
            }
            Console.ReadLine();
        }
    }
}
