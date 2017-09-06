using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    class notification
    {
        public virtual void display()
        {
            Console.WriteLine("Send Notification");
        }
    }
    class email : notification
    {
        public override void display()
        {
            Console.WriteLine("Send via Email");
        }
    }
    class sms : notification
    {
        public override void display()
        {
            Console.WriteLine("Send via sms");
        }
    }
}
