﻿using System;
using ConsoleApp;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1,"John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}