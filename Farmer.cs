using System;
namespace Assessment3Practice
{
    public class Farmer : Villiager
    { 
        public Farmer()
        {
            Hunger = 1;
        }

        public override int Farm()
        {
            return 2; 
        }
    }
}
