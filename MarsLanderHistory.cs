using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Christopher Hovsepian  BIT 143  Fall 2019  A1.0


/// list of questions:
/// 1.  How do I resize the array without useing  Array.Resize(.....  (-15)


namespace MarsLander
{
    class MarsLanderHistory
    {
        RoundInfo[] rounds = new RoundInfo[10];
        int numRounds;
        // Clone is provided to you; it'll create a copy of the current history
        // Look for opportunities to use it elsewhere.
        public MarsLanderHistory Clone()
        {
            MarsLanderHistory copy = new MarsLanderHistory();
            copy.rounds = new RoundInfo[this.rounds.Length];
            copy.numRounds = this.numRounds; 
            for (int i = 0; i < copy.numRounds; i++) 
                copy.rounds[i] = this.rounds[i];

            return copy;
        }

        public int GetHeight(int x)
        {
            return rounds[x].GetHeight();
        }
        public int GetSpeed(int x)
        {
            return rounds[x].GetSpeed();
        }

        public void AddRound(int height, int speed)
        {
            if (numRounds == rounds.Length)
            {
                ArrayResize();
            }
            rounds[numRounds] = new RoundInfo(height, speed);
            numRounds++;
        }

        public RoundInfo[] ArrayResize()
        {
            RoundInfo[] test = new RoundInfo[rounds.Length + 10];
            int xx = this.numRounds;
            for (int i = 0; i < xx; i++)
                test[i] = this.rounds[i];
            rounds = test;
            return test;
        }

        public int NumberOfRounds()
        {
            return numRounds;
        }
        // you'll need other methods in order to make the PrintHistory command work

        ////public void AddRound(int height, int speed)// if all else fails, this works.
        ////{
        ////    rounds[numRounds] = new RoundInfo(height, speed);
        ////    numRounds++;
        ////    if (numRounds == rounds.Length)
        ////    {
        ////        Array.Resize(ref rounds, rounds.Length + 10);
        ////        //use clone() as a template to increase the size of the array
        ////    }
        ////}
    }

    // This is provided to you; you shouldn't need to add anything to it, but 
    // if you want to you are welcome to do so                            
    class RoundInfo// must be unchanged
    {
        private int height;
        private int speed;

        #region Accessors
        public int GetHeight()
        {
            return height;
        }
        public void SetHeight(int newValue)
        {
            height = newValue;
        }

        public int GetSpeed()
        {
            return speed;
        }
        public void SetSpeed(int newValue)
        {
            speed = newValue;
        }
        #endregion Accessors

        public RoundInfo(int h, int s)
        {
            height = h;
            speed = s;
        }
    }
}
