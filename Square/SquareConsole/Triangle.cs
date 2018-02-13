
namespace SquareConsole
{
	class Triangle : Figure
	{
		int side;
		int height;
		double square;

		public Triangle(int side, int height, string name = "triangle")
		{
			this.side = side;
			this.height = height;
			this.name = name;
		}
		public override double CalculateSquare()
		{
			return square = side * height / 2;
		}
		public override string FileSavingFormat()
		{
			return $"{name}|{side}|{height}|{square}";
		}
	}
}
