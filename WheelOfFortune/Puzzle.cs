using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortune
{
    class Puzzle
    {
        public string Self;
        public bool IsComplete { get; private set; }
        public HashSet<char> UniqueLetters;
        public HashSet<char> GuessedLetters;

        public Puzzle()
        {
            Self = "one possible solution";
            UniqueLetters = new HashSet<char>();
            GuessedLetters = new HashSet<char>();

            GenerateUniqueLetters(Self);
        }

        public void GenerateUniqueLetters(string phrase)
        {
            foreach (char letter in phrase)
            {
                if (letter != 'c')
                {
                    UniqueLetters.Add(letter);
                }
            }
        }

        public void DisplayPuzzle()
        {
            var puzzle = new StringBuilder();
            foreach (char letter in Self)
            {
                if (letter == ' ')
                {
                    puzzle.Append(" ");
                }
                else if (GuessedLetters.Contains(letter))
                {
                    puzzle.Append(letter.ToString());
                }
                else
                {
                    puzzle.Append("-");
                }
            }
            Console.WriteLine(puzzle);
        }

        public void AddLetterToGuessedLetters(Guess guess)
        {
            GuessedLetters.Add(Convert.ToChar(guess.Self));
        }
    }
}
