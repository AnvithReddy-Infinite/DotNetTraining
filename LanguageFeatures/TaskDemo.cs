using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LanguageFeatures
{
    internal class TaskDemo
    {
        public void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                WriteLine("Method1 Called");
                Thread.Sleep(1000);
            }
        }

        public void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                WriteLine("Method2 Called");
                Thread.Sleep(1000);
            }
        }

        public void Method3()
        {
            Task t1 = new Task(Method1);
            t1.Start();
            Task t2 = new Task(Method2);
            t2.Start();
        }

        public void Method4()
        {

        }
    }
}
