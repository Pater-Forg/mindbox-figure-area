namespace FigureArea.Test
{
	public class FigureAreaTests
	{
		[Fact]
		public void Area_CircleValidRadius_ShouldComputeAreaOfCircle()
		{
			double radius = 5.3;
			var circle = new Circle(radius);
			var area = circle.Area;
			double expectedArea = 88.24734;
			Assert.Equal(expectedArea, area, 4);
		}

		[Fact]
		public void Area_CircleInvalidRadius_ShouldThrowArgumentException()
		{
			double zeroRadius = 0;
			double negativeRadius = -5.3;
			Assert.Throws<ArgumentException>(() => new Circle(zeroRadius));
			Assert.Throws<ArgumentException>(() => new Circle(negativeRadius));
		}

		[Fact]
		public void Area_TriangleValidSides_ShouldComputeAreaOfTriangle()
		{
			double a = 5.86314;
			double b = 5.48525;
			double c = 3.21925;
			double expectedArea = 8.69760;
			var triangle = new Triangle(a, b, c);
			Assert.Equal(expectedArea, triangle.Area, 4);
		}

		[Fact]
		public void Area_TriangleNotExist_ShouldThrowArgumentException()
		{
			double a = 10;
			double b = 3;
			double c = 4;
			Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
		}

		[Fact]
		public void Area_TriangleInvalidSides_ShouldThrowArgumentException()
		{
			double a = -5.8631;
			double b = 5.4853;
			double c = 3.2193;
			Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
			Assert.Throws<ArgumentException>(() => new Triangle(0, b, c));
		}
	}
}