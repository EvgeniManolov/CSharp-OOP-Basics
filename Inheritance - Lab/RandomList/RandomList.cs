using System;
using System.Collections;

namespace Rando
{
    public class RandomList : ArrayList
    {
        private Random rnd;
        public RandomList()
        {
            this.rnd = new Random();
        }

        public string RandomString()
        {
            return "";
        }
    }
}

