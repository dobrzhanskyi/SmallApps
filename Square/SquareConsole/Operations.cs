using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SquareConsole
{
	class Operations
	{
		public List<Figure> figureList = new List<Figure>();

		public void ShowError()
		{
			Console.WriteLine("Bad Input");
		}

		public void CreateSquare(string inputValues)
		{
			try
			{
				int side = Convert.ToInt32(inputValues);
				figureList.Add(new Square(side));
				ShowSquare();
			}
			catch (FormatException)
			{
				ShowError();
			}
			catch
			{
				ShowError();
			}
		}

		public void CreateTriangle(string inputValues)
		{
			try
			{
				string[] subTriangleValue = inputValues.Split(' ');
				int side = Convert.ToInt32(subTriangleValue[0]);
				int height = Convert.ToInt32(subTriangleValue[1]);
				figureList.Add(new Triangle(side, height));
				ShowSquare();
			}
			catch (FormatException)
			{
				ShowError();
			}
			catch
			{
				ShowError();
			}
		}

		public void CreateCircle(string inputValues)
		{
			try
			{
				int radius = Convert.ToInt32(inputValues);
				figureList.Add(new Circle(radius));
				ShowSquare();
			}
			catch (FormatException)
			{
				ShowError();
			}
			catch
			{
				ShowError();
			}
		}

		public void ShowSquare()
		{
			Console.WriteLine("Square : " + figureList.Last().CalculateSquare());
		}

		private void SaveFiguresToFile(List<Figure> figures)
		{
			using (StreamWriter stream = new StreamWriter(@"figures.ms"))
			{
				for (int i = 0; i < figures.Count; i++)
				{
					stream.WriteLine(figures[i].FileSavingFormat());
				}
			}
		}

		public void Save()
		{
			SaveFiguresToFile(figureList);
		}
	}
}
