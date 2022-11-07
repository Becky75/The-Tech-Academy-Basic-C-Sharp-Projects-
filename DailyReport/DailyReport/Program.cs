using System;

namespace DailyReport
{
    class Program
    {
		static void Main(string[] args)
		{
			//this is to start print with "Academy of Learning Career College"
			// next line "Student Daily Report"

			Console.WriteLine("Academy of Learning Career College");

			Console.WriteLine("Student Daily Report");

			//this is a string  -What is your name?, 

			Console.WriteLine("What is your name?");

			string yourName = Console.ReadLine();

			//this is string program-What course are your in?'

			Console.WriteLine("What course are you in?");
			string courseName = Console.ReadLine();

			//- this is byte program for "What page number?"
			  //commenta
			Console.WriteLine("What page are you on?");
			int PageNumber = Convert.ToInt32(Console.ReadLine());
		

			// this is a question in Boolean -Do you need help with anything?Please answer "true" or "false"

			Console.WriteLine("Do you need help with anything? Please answer 'true or false'");
	
			bool answer = Convert.ToBoolean(Console.ReadLine());

			//- this is a string for the comment section - Were there any positive experiences you'd like to share?Please be specific.

			Console.WriteLine("Were there any positive experiences you'd like to share?Please be specific.");
			string answerto = Console.ReadLine();
		
			//the is a byte program - How many hours did you study today?

			Console.WriteLine("How many hours did you study today?");
			int hours = Convert.ToInt32(Console.ReadLine());
			
			//this is the ending statment. 

			Console.WriteLine("Thank you for your answers.An instructor will respond shortly.Have a great day!");
			Console.ReadLine();

		}
	}
}
