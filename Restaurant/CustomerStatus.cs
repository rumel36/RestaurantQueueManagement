using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public enum emMeal { None, Appetizer, Main, Desert, Done }
    public class CustomerStatus
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public emMeal Meal { get; set; }

    }
}
