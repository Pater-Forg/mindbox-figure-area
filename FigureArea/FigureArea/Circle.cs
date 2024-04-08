namespace FigureArea
{
	public class Circle : IComputableArea
	{
        public double Radius { get; init; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater then zero");
            Radius = radius;
        }
        public double Area => Math.PI * Radius * Radius;
    }
}
