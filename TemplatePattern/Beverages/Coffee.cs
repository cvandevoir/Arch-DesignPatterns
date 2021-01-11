﻿using System;

namespace TemplatePattern
{
    internal class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Add Coffe Grounds to water and boil");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Add Milk and Sugar");
        }

    }
}