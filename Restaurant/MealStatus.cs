using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MealStatus
    {
        public void OnMealChanged(object source, MealStatusArgs e)
        {

            Console.WriteLine("{0} {1} is having {2}", e.MealState.FirstName, e.MealState.LastName, e.MealState.Meal);
        }
    }
}
