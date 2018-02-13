
namespace SquareConsole
{
	abstract class Figure
	{
		public int side, height, radius;
		public double square;
		public string name;

		public abstract double CalculateSquare();
		public abstract string FileSavingFormat();
	}
}
