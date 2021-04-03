using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Christopher Hovsepian  BIT 143  Fall 2019  A1.0

namespace MarsLander
{
    class MarsLander
    {
        // positive speed == speed towards Mars (DOWNWARD)

        public MarsLanderHistory mlh = new MarsLanderHistory();

        // you'll need to add data fields & methods so that the rest of the program
        // can use the various properties of the lander (such as height, speed, etc)

        public MarsLander()
        {
        }

        private int mlSpeed = 100;
        private int mlHeight = 1000;
        private int mlFuel = 500;

        public void CalculateNewSpeed(int fuelToBurn)
        {
            int speedNextRound = mlSpeed + 50 - fuelToBurn;
            mlSpeed = speedNextRound;// this is correct
        }

        public void MoveShipDown()
        {
            int shipDown = getSpeed();//this moves the ship down
            int shipHeight = getHeight();
            int newHeight = shipHeight - shipDown;

            if(newHeight < 0)
            {
                setHeight(0);
            }
            else
            {
                setHeight(newHeight);
            }
        }

        public MarsLanderHistory GetHistory()
        {
            return mlh;
        }

        public int getSpeed()
        {
            return mlSpeed;
        }
        public void setSpeed(int x)
        {
            mlSpeed = x;
        }


        public int getHeight()
        {
            return mlHeight;
        }
        public void setHeight(int x)
        {
            mlHeight = x;   
        }


        public int getFuel()
        {
            return mlFuel;
        }
        public void setFuel(int x)
        {
            mlFuel = x;
        }
    }//end ml class
}//end ns
