using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class CustomerStatusArgs : EventArgs {

        public CustomerStatus CustomerStatus { get; set; } 
    }
    public class Table
    {
        public delegate void NotifyEventHandler(object source, CustomerStatusArgs args);
        public event NotifyEventHandler Notified;
        public void Status(CustomerStatus customerStatus) {

            if ((customerStatus.Meal == emMeal.None)|| (customerStatus.Meal == emMeal.Done))
            {
                Console.WriteLine("Table is open");
                OnStatusNotification(customerStatus);
            }
        }

        protected virtual void OnStatusNotification(CustomerStatus customerStatus) {
            if (Notified != null)
                Notified(this, new CustomerStatusArgs { CustomerStatus= customerStatus });
        
        }
    }
}
