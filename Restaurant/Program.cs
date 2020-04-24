using System;
using System.Collections.Generic;

namespace Restaurant
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<CustomerStatus> customers = new List<CustomerStatus>();
            customers.Add(new CustomerStatus() { FirstName ="Joe", LastName = "Smith", Meal = emMeal.None });
            customers.Add(new CustomerStatus() { FirstName ="Sheryl", LastName = "Doug", Meal = emMeal.None });
            customers.Add(new CustomerStatus() { FirstName = "Christan", LastName = "Wills", Meal = emMeal.None });
            customers.Add(new CustomerStatus() { FirstName = "Will", LastName ="Smith", Meal = emMeal.None });
            customers.Add(new CustomerStatus() { FirstName = "Andre", LastName = "Istemal", Meal = emMeal.None });
           
            var customerModel = new CustomerStatus();
            var mealState = new MealStatus();
            int count = 0;
            if (customers.Count != 0)
            {
                foreach (var cs in customers)
                {

                    var table = new Table();
                    var customer = new Customer();
                    table.Notified += customer.OnStatusNotification;
                    table.Status(cs);
                    customer.MealChanged += mealState.OnMealChanged;
                    customer.customerStatus(cs);
                    count++;
                }

                if (customers.Count == count) {

                    Console.WriteLine("Everyone is Full");
                }
            }
        }

    }
}
