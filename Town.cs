using System;
using System.Collections.Generic;

namespace Assessment3Practice
{
    public class Town
    {
        // PROPERTIES:

        // Public  | DataType | Name | { get; set; }
        public List<Villiager> Villiagers { get; set; }


        // Contsructor (default)
        public Town() // default constructor takes in NO parameters
        {
            // Creating the Villiagers Object.
            Villiagers = new List<Villiager>();

            // Adding villagers to the list object.
            Villiagers.Add(new Farmer());
            Villiagers.Add(new Slacker());
            Villiagers.Add(new Slacker());
            Villiagers.Add(new Slacker());

        }

        // Constructor (overloaded)
        public Town(List<Villiager> villagers)
        {
            Villiagers = villagers;
        }

        // Methods

        //public Harvest()- returns an int
        public int Harvest()
        {
            //find the total of all the villagers Farm() method
            //return the total
            int total = 0;

            foreach (var villiager in Villiagers)
            {
                total += villiager.Farm();// how to call a method on the object== The villiager is the Object
            }
            return total;
        }

        //public CalcFoodConsumptionn() - returns an int
        public int CalculateFoodConsumption()
        {
            //Find the total of all the Villagers' Hunger properties
            //return the total
            int hungerTotal = 0;

            foreach (var villiager in Villiagers)
            {
                hungerTotal += villiager.Hunger;// how to call property (will not have a static modifier,  Object)
            }
            return hungerTotal;
        }

        public bool SurviveTheWinter()
        {

            int crops = Harvest();
            int foodEat = CalculateFoodConsumption();

            if (foodEat <= crops)
            {
                return true;
            }
            else
            {
                return false;
            }

            // Evalutate if the food consumption is less than the hunger
            // if true return true else return false

        }
    }
}
