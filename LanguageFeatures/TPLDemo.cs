using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    internal class TPLDemo
    {
        public void NonParallel()
        {
            //runs slower
            //does not use library
            //i want to keep tracj how much time it took to run the loop
            Stopwatch sw = new Stopwatch();
            sw.Start();//timer starts
            for (int i = 0; i < 16; i++)
            {//by default its uses single thread to do the job
             //by default it using single core or processor to do the job
                Console.WriteLine("non parallel method running" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
            sw.Stop();  //timer ends
            Console.WriteLine("Total milliseconds took is" + sw.ElapsedMilliseconds);
        }
        public void Pareller()
        {
            //runs faster
            //uses library
            Stopwatch sw = new Stopwatch();
            sw.Start();//timer starts
            Parallel.For(0, 16, i =>
            { //by default it using single core or processor to do the job
                Console.WriteLine("parallel method running" + Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            });
            sw.Stop();  //timer ends
            Console.WriteLine("Total milliseconds took is" + sw.ElapsedMilliseconds);

            // 1. It uses multiple threads behind the scene
            //2. The loop is broken into multiple parts, each part runs simultaneously from different cors.
            // 3. Each part of loop is called a task.
            // 4. Internally it uses task class, to run simaultaneously.
            // 5. Each task runs on a separate thread.
            // 6. Task always uses thread pool threads.
            // 7. Thread pool is a pool of threads already running in the memory.

            //realtime usage:
            //you have send an email to 10000 people simultaneously
            // you want to log to database 
            //send alerts or sms for all users simultaneously
        }
    }
}
