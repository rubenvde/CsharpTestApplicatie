using System;
namespace CsharpTestApplicatie
{
	public class Question
	{
        public String Text { get; set; } = string.Empty;
        public virtual String Answer { get; set; } = string.Empty;

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
