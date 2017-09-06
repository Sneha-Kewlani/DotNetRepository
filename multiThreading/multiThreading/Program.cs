using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace multiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            multiThread m = new multiThread();
            //m.threadExecute();

            foregroundBackground fb = new foregroundBackground();
            //fb.fb();

            divide d = new divide();
            //d.threadExecute();

            threadPool tp = new threadPool();
            //tp.threadExecute();

            tpl tpl = new tpl();
            tpl.threadExecute();
        }
    }
}
