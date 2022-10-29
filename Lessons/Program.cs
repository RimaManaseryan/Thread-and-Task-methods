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
