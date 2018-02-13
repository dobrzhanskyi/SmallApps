using System;

namespace SquareConsole
{

	class ConsoleUI
	{
		Operations operations = new Operations();

		void ShowInstructions()
		{
			Console.WriteLine("This program calculates square of different figures");
			Console.WriteLine("Type help: for instructions");
		}

		void ShowHelp()
		{
			Console.WriteLine("Commands square: , circle: , triangle: ,save:");
			Console.WriteLine("Use only digits");
			Console.WriteLine("For square type the length of side after :");
			Console.WriteLine("For triangle type the lenght of side and height separated by space after :");
			Console.WriteLine("For circle type radius after :");
			Console.WriteLine("For saving type save: ,it will be saved in *figures.ms");
		}

		public void CheckingConsole()
		{
			ShowInstructions();
			var inputCommand = String.Empty;
			while (true)
			{
				{
					inputCommand = Console.ReadLine();
				}
				if (inputCommand == "exit")
				{
					break;
				}
				if (!inputCommand.Contains(":"))
				{
					CheckingConsole();
				}
				string[] split = inputCommand.Split(':');
				string command = split[0];
				if (split.Length < 1)
				{
					operations.ShowError();
				}
				string inputValues = split[1];
				switch (command)
				{
					case "square":
						operations.CreateSquare(inputValues);
						break;
					case "triangle":
						operations.CreateTriangle(inputValues);
						break;
					case "circle":
						operations.CreateCircle(inputValues);
						break;
					case "help":
						ShowHelp();
						break;
					case "save":
						operations.Save();
						break;
					default: break;
				}
			}
		}
	}
}
