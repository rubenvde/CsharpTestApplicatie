using System;
using System.Collections.Generic;

namespace CsharpTestApplicatie
{
	public class ChoiceQuestion : Question
	{
        private static int FindIndex<T,U>(Dictionary<T,U> d, Predicate<KeyValuePair<T,U>> p)
        {
            int i = 0;
            foreach(var pair in d)
            {
                if (p(pair)) return i;
                i++;
            }
            return -1;
        }
        public Dictionary<string, bool> Choices { get; set; } = new Dictionary<string, bool>();

        public override string Answer
        {
            get { return (1 + FindIndex(Choices, pair => pair.Value)).ToString(); }
            set { throw new NotSupportedException("you can't set an answer this way"); }
        }

        public void AddChoice(String choice, bool correct)
		{
			Choices.Add(choice, correct);
		}

		override public void Display()
		{
			// Display the question text 
			base.Display();
            // Display the answer choices
            int i = 1;
			foreach(var choise in Choices)
			{
				Console.WriteLine($"{i} : {choise.Key}");
                i++;
			}
		}

	}
}
