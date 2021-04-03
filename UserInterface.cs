using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Christopher Hovsepian  BIT 143  Fall 2019  A1.0

namespace MarsLander
{
    class UserInterface
    {

        public void PrintGreeting()
        {
            Console.WriteLine("Welcome to the Mars Lander game!");
        }

        // This should print the 'picture' of hte lander
        // for example:
        //      1000m: *
        //      900m: 
        //      800m:
        // etc, etc
        public void PrintLocation(MarsLander Eagle2 )
        {

            int hals = Eagle2.getHeight();// hals = height above lunar surface

            //There has to be a better way....
            // do I need a loop??

            //if (hals >= 3200 && hals < 3300)
            //    Console.WriteLine("3200m*\n3100m\n3000m\n2900m\n2800m\n2700m\n2600m\n2500m\n2400m\n2300m\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            //else if (hals >= 3100 && hals < 3200)
            //    Console.WriteLine("3100m*\n3000m\n2900m\n2800m\n2700m\n2600m\n2500m\n2400m\n2300m\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            //else if (hals >= 3000 && hals < 3100)
            //    Console.WriteLine("3000m*\n2900m\n2800m\n2700m\n2600m\n2500m\n2400m\n2300m\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            //else if (hals >= 2900 && hals < 3000)
            //    Console.WriteLine("2900m*\n2800m\n2700m\n2600m\n2500m\n2400m\n2300m\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            //else if (hals >= 2800 && hals < 2900)
            //    Console.WriteLine("2800m*\n2700m\n2600m\n2500m\n2400m\n2300m\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            //else if (hals >= 2700 && hals < 2800)
            //    Console.WriteLine("2700m*\n2600m\n2500m\n2400m\n2300m\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            //else if (hals >= 2600 && hals < 2700)
            //    Console.WriteLine("2600m*\n2500m\n2400m\n2300m\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            //else if (hals >= 2500 && hals < 2600)
            //    Console.WriteLine("2500m*\n2400m\n2300m\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            if (hals >= 2400 && hals < 2500)
                Console.WriteLine("2400m*\n2300m\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");

            else if (hals >= 2300 && hals < 2400)
                Console.WriteLine("2300m*\n2200m\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 2200 && hals < 2300)
                Console.WriteLine("2200m*\n2100m\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 2100 && hals < 2200)
                Console.WriteLine("2100m*\n2000m\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 2000 && hals < 2100)
                Console.WriteLine("2000m*\n1900m\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 1900 && hals < 2000)
                Console.WriteLine("1900m*\n1800m\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 1800 && hals < 1900)
                Console.WriteLine("1800m*\n1700m\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 1700 && hals < 1800)
                Console.WriteLine("1700m*\n1600m\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 1600 && hals < 1700)
                Console.WriteLine("1600m*\n1500m\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 1500 && hals < 1600)
                Console.WriteLine("1500m*\n1400m\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 1400 && hals < 1500)
                Console.WriteLine("1400m*\n1300m\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 1300 && hals < 1400)
                Console.WriteLine("1300m*\n1200m\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 1200 && hals < 1300)
                Console.WriteLine("1200m*\n1100m\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 1100 && hals < 1200)
                Console.WriteLine("1100m*\n1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            
            else if (hals >= 1000 && hals < 1100)
                Console.WriteLine("1000m*\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 900 && hals < 1000)
                Console.WriteLine("1000m\n900m*\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 800 && hals < 900)
                Console.WriteLine("1000m\n900m\n800m*\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 700 && hals < 800)
                Console.WriteLine("1000m\n900m\n800m\n700m*\n600m\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 600 && hals < 700)
                Console.WriteLine("1000m\n900m\n800m\n700m\n600m*\n500m\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 500 && hals < 600)
                Console.WriteLine("1000m\n900m\n800m\n700m\n600m\n500m*\n400m\n300m\n200m\n100m\n0m");
            else if (hals >= 400 && hals < 500)
                Console.WriteLine("1000m\n900m\n800m\n700m\n600m\n500m\n400m*\n300m\n200m\n100m\n0m");
            else if (hals >= 300 && hals < 400)
                Console.WriteLine("1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m*\n200m\n100m\n0m");
            else if (hals >= 200 && hals < 300)
                Console.WriteLine("1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m*\n100m\n0m");
            else if (hals >= 100 && hals < 200)
                Console.WriteLine("1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m*\n0m");
            else if (hals >= 0 && hals < 100)
                Console.WriteLine("1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m*");
            else if (hals < 0 )// I dont need this, it was for testing
                Console.WriteLine("1000m\n900m\n800m\n700m\n600m\n500m\n400m\n300m\n200m\n100m\n0m******");
        }

        // This prints out the info about the lander
        // For example:
        //      Exact height: 1350 meters
        //      Current (downward) speed: -350 meters/second
        //      Fuel points left: 0
        public void PrintLanderInfo(MarsLander Eagle2)
        {
            int theSpeed = Eagle2.getSpeed();
            int theFuel = Eagle2.getFuel();
            int theHeight = Eagle2.getHeight();

            Console.WriteLine("Exact height: {0}\nCurrent (downward) speed: {1}\nFuel points left: {2}"
                , theHeight, theSpeed, theFuel);
        }

        // This will ask the user for how much fuel they want to burn,
        // verify that they've type in an acceptable integer,
        //  (repeatedly asking the user for input if needed),
        // and will then return that number back to the main method
        public int GetFuelToBurn(MarsLander Eagle2)
        {
            int fuelLeft = Eagle2.getFuel();
            int desiredBurn;
            Console.WriteLine("How many points of fuel would you like to burn? You have {0} fuel units left", fuelLeft);
            Int32.TryParse(Console.ReadLine(), out desiredBurn);

            while(desiredBurn < 0 || desiredBurn > fuelLeft)
            {
                if (desiredBurn > fuelLeft) 
                {
                    Console.WriteLine("ERROR, you cant use more fuel than you have left in the tank! You have {0} fuel points left", fuelLeft);
                    Int32.TryParse(Console.ReadLine(), out desiredBurn);
                }
                else
                {
                    Console.WriteLine("You cant use a negative amount of fuel, try again");
                    Int32.TryParse(Console.ReadLine(), out desiredBurn);
                }
            }
            return desiredBurn;
            #region notes
            ////Here are some useful print statements that you'll need: // probably if statements
            //Console.WriteLine("You can't burn less than 0 points of fuel!");
            //Console.WriteLine("You don't have {0} points of fuel!", nFuel);
            //Console.WriteLine("You need to type a whole number of fuel points to burn!");
            //Console.WriteLine();
            //Console.WriteLine("Just as a reminder, here's where the lander is: ");
            //PrintLanderInfo(ml);
            //Console.WriteLine("How many points of fuel would you like to burn?");
            //Console.WriteLine();
            //return -1; 
            #endregion notes
        }

        // This will only be called once the lander is on the surface of Mars, 
        //  and will tell the player if they successfully landed or if they crashed
        public void PrintEndOfGameResult(MarsLander ml, int maxSpeed)
        {
            Console.WriteLine();
            if (maxSpeed >= ml.getSpeed())
            {
                Console.WriteLine("Congratulations!! You've successfully landed your Mars Lander, without crashing!!!"); 
            }
            else
            {
                Console.WriteLine("The maximum speed for a safe landing is {0}; your lander's current speed is {1}", maxSpeed, ml.getSpeed());
                Console.WriteLine("You have crashed the lander into the surface of Mars, killing everyone on board,");
                Console.WriteLine("costing NASA millions of dollars, and setting the space program back by decades!");
            }
            PrintHistory(ml.GetHistory()); /* ml.GetHistory() */
        }

        // This will print out, for example: 
        //      Round # 	Height (in m) 	Speed (downwards, in m/s)
        //      0 		    850 	    	150
        //      1 		    650 		    200
        //  etc
        //
        // This is provided to you, but you'll need to add stuff elsewhere in order to make it work 
        public void PrintHistory(MarsLanderHistory mlh)
        {
            Console.WriteLine("Round #\t\tHeight (in m)\tSpeed (downwards, in m/s)");
            for (int i = 0; i < mlh.NumberOfRounds(); i++) 
            {
                // should round 1 be a 1 or 0?
                //int q = i + 1; // then change i to q below

                Console.WriteLine("{0}\t\t{1}\t\t{2}", i, mlh.GetHeight(i), mlh.GetSpeed(i));
            }
        }
    }
}
