using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Player
    {
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;

            // can implement score here in the future
        }
    }
}
