using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    class employee
    {
        public int salary;
        public employee(int sal)
        {
            salary = sal;
        }
        public virtual void salCalculate()
        {
            Console.WriteLine("Salary: ");
        }
    }
    class trainer : employee
    {
        public trainer(int sal) : base(sal)
        {
        }

        public override void salCalculate()
        {
            Console.WriteLine("Trainer Salary: "+ 3 * salary);
        }
    }
    class admin : employee
    {
        public admin(int sal) : base(sal)
        {
        }

        public override void salCalculate()
        {
            Console.WriteLine("Admin Salary: "+ 4 * salary);
        }
    }

}
