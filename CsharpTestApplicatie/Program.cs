using System;

namespace CsharpTestApplicatie
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Opgave 9 Java naar C# maken


			/*
			Question q = new Question()
			{
				Text = "Who was the inventor of Java?",
				Answer = "James Gosling"
			};
			*/

			var first = new ChoiceQuestion()
			{
				Text = "What was the original name of the Java language?",
                Choices =
                {
                    {"*7", false },
                    {"Duke", false },
                    {"Oak", true },
                    {"Gosling", false }

                }
			};


			ChoiceQuestion second = new ChoiceQuestion()
			{
				Text = "In which country was the inventor of Java born?"
			};
			second.AddChoice("Australia", false);
			second.AddChoice("Canada", true);
			second.AddChoice("Denmark", false);
			second.AddChoice("United States", false);


			PresentQuestion(first);
			PresentQuestion(second);
		}

		public static void PresentQuestion(ChoiceQuestion q)
		{
			q.Display();
			Console.Write("Your answer: \t");
			String response = Console.ReadLine();
			Console.WriteLine(q.CheckAnswer(response));
		}
	}
}
