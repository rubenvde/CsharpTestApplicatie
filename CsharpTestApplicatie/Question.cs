using System;
namespace CsharpTestApplicatie
{
	public class Question
	{
		public String Text { get; set; }
		public String Answer { get; set; }

		public Question()
		{
			Text = "";
			Answer = "";
		}

		public bool CheckAnswer(String response)
		{
			return response == Answer;
		}

		public virtual void Display()
		{
			Console.WriteLine(Text);
		}
	}
}
