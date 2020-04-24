using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MealStatusArgs : EventArgs
    {
        public CustomerStatus MealState { get; set; }
    }
    public class Customer
    {
        public delegate void MealChangedEventHandler(object source, MealStatusArgs args);
        public event MealChangedEventHandler MealChanged;

        public void OnStatusNotification(object source, CustomerStatusArgs e)
        {
            Console.WriteLine("{0} {1} got a table", e.CustomerStatus.FirstName, e.CustomerStatus.LastName);
        }


        public void customerStatus(CustomerStatus status)
        {
            
            foreach (var m in Enum.GetNames(typeof(emMeal)))
            {

                var meal = (emMeal)Enum.Parse(typeof(emMeal), m);
                if (!m.Contains("None")) { 
                OnMealChanged(new CustomerStatus() { FirstName = status.FirstName, LastName = status.LastName, Meal = meal });
                 }
             }
        }
        protected virtual void OnMealChanged(CustomerStatus status) {
            if (MealChanged != null)
                MealChanged(this, new MealStatusArgs { MealState = status} );
        
        }

    }
}
