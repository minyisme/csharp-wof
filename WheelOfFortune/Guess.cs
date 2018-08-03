using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Guess
    {
        public string Self { get; private set; }
        
        public Guess(string playerGuess)
        {
            Self = playerGuess;
        }

        public bool isValid()
        {
            if (Self.Length != 1)
            {
                Console.WriteLine("Your guess needs to be 1 letter in length.");
                return false;
            }
            if ((Convert.ToChar(Self) <= 'A' && Convert.ToChar(Self) >= 'Z') || (Convert.ToChar(Self) <= 'a' && Convert.ToChar(Self) >= 'z'))
            {
                Console.WriteLine("Your guess needs to be an alphabetical letter");
                return false;
            }
            return true;
        }
    }
}
