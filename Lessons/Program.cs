using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.IO;
using System.Threading;
//using System.Web.Mvc;

namespace Lessons
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();


            Thread thread2 = new Thread(program.M1);
            thread2.Start();
            Thread thread3 = new Thread(program.M2);
            thread3.Start();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Main");
            }
            Console.ReadLine();
            Thread thread1 = new Thread(program.PrintOneByThread);
            thread1.Start();

            Task task1 = new Task(() => Console.WriteLine("Task1 is executed."));
            task1.Start();
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed."));
            Task task3 = Task.Run(program.PrintOneAsync);
            Task task4 = Task.Run(program.PrintTwoAsync);
            #region dzer chtal
            Console.ReadLine();
            #endregion
        }

        public void PrintOne()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(1);
            }
        }
        public void PrintTwo()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(2);
            }
        }
        public void PrintOneByThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write(1);
            }
        }
        public void PrintTwoByThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                Console.Write(2);
            }
        }
        public void PrintOneByTask()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(1);
            };
        }
        public void PrintTwoByTask()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(2);
            };
        }
        public async Task PrintOneAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(1);
                }
            });
        }
        public async Task PrintTwoAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(2);
                }
            });
        }
    
        public void M1()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("MMM111");
            }
        }
        public void M2()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("MMM222222");
            }


        }


    }
    
}
