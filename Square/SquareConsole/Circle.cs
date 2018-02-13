using System;

namespace SquareConsole
{
	class Circle : Figure
	{
		int radius;
		double square;

		public Circle(int radius, string name = "circle")
		{
			this.radius = radius;
			this.name = name;
		}
		public override double CalculateSquare()
		{
			return square = this.radius * this.radius * Math.PI;
		}
		public override string FileSavingFormat()
		{
			return $"{name}|{radius}|{square}";
		}
	}
}
