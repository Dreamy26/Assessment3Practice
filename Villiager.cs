using System;
namespace Assessment3Practice
{
    public abstract class Villiager // parent class- defines how the other classes work
    {
       public int Hunger{ get; set; } //All gettersetters are properties

       public abstract int Farm(); // MUST IMPLIMENT !!! same as a reg method but no body, Abstract can not be private.. you need to inherit from
       
        
       
    }
}
