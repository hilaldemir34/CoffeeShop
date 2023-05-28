using CoffeeShop.Abstract;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;
using System;

namespace CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2, 6, 1999), FirstName = "Jesica", LastName = "Kith", NationalityId = "18965742598" });
        }
    }
}
