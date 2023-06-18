using System;
using System.Collections.Generic;
using System.Linq;

// Client code
var cars = new List<Car>
{
    new Car { Make = "Toyota", Model = "Corolla", Year = 2018, Price = 15000 },
    new Car { Make = "Toyota", Model = "Camry", Year = 2019, Price = 20000 },
    new Car { Make = "Honda", Model = "Civic", Year = 2020, Price = 18000 },
    new Car { Make = "Honda", Model = "Accord", Year = 2021, Price = 25000 },
    new Car { Make = "Nissan", Model = "Altima", Year = 2017, Price = 12000 }
};

var webShop = new WebShop(cars);

webShop.FilterByMake("Toyota");
webShop.AddToCart(cars[0]);
webShop.FilterByYear(2020);
webShop.RemoveFromCart(cars[0]);

Console.WriteLine("End of program.");
