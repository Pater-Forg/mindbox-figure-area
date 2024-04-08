namespace FigureArea
{
	public class Triangle : IComputableArea
	{
		public double A { get; init; }
		public double B { get; init; }
		public double C { get; init; }
		public Triangle(double a, double b, double c)
        {
			if (a <= 0 || b <= 0 || c <= 0)
				throw new ArgumentException("Sides of triangle must be greater then zero");
			if (!(a < b + c && b < a + c && c < a + b))
				throw new ArgumentException("Triangle with given sides doesn't exist");
			A = a;
			B = b;
			C = c;
        }
        public double Area
		{
			get
			{
				double p = (A + B + C) / 2;
				return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
			}
		}
	}
}
