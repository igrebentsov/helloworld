﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageLocator messageLocator = new MessageLocator();
            string message = messageLocator.Invoke();
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
