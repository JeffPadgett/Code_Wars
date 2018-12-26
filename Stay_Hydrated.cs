using System;


namespace Stay_Hydrated
{
    public class EmptyClass
    {
        /*Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
You get given the time in hours and you need to return the number of litres Nathan will drink, 
rounded to the smallest value.

For example:

time = 3 ----> litres = 1

time = 6.7---> litres = 3

time = 11.8--> litres = 5 */




        public static int Litres(double time)
        {
            int litres;
            return litres = (int)System.Math.Floor(0.5 * time);

            //Best Practice
            // return (int)(time/2);
        }

    }

    
}
