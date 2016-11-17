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

			ChoiceQuestion first = new ChoiceQuestion()
			{
				Text = "What was the original name of the Java language?"
			};
			first.AddChoice("*7", false);
			first.AddChoice("Duke", false);
			first.AddChoice("Oak", true);
			first.AddChoice("Gosling", false);


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
			Console.WriteLine("Your answer: ");
			String response = Console.ReadLine();
			Console.WriteLine(q.CheckAnswer(response));
		}
	}
}
