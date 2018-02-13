
namespace SquareConsole
{
	class Square : Figure
	{
		int side;
		double square;

		public Square(int side, string name = "square")
		{
			this.side = side;
			this.name = name;
		}
		public override double CalculateSquare()
		{
			return square = side * side;
		}
		public override string FileSavingFormat()
		{
			return $"{name}|{side}|{square}";
		}
	}
}
