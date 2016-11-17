using System;
using System.Collections.Generic;

namespace CsharpTestApplicatie
{
	public class ChoiceQuestion : Question
	{
		public List<string> choices { get; set; }

		public ChoiceQuestion()
		{
			choices = new List<string>();
		}

		public void AddChoice(String choice, bool correct)
		{
			choices.Add(choice); 
			if (correct)
			{
				// Convert choices.size() to string
				String choiceString = "" + choices.Count; 
				Answer = choiceString;
			}
		}

		override public void Display()
		{
			// Display the question text 
			base.Display();
			// Display the answer choices
			for (int i = 0; i < choices.Count; i++)
			{
				int choiceNumber = i + 1;
				Console.WriteLine(choiceNumber + ": " + choices[i]);
			}
		}

	}
}
