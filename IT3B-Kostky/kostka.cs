using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT3B_Kostky
{
    internal class kostka
    {
        private static Random random = new Random();
        public int Value { get; private set; }

        public kostka()
        {
            Roll();
        }

        public void Roll()
        {
            Value = random.Next(1, 7);
        }
    }
}
