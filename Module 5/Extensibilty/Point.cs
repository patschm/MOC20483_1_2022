namespace Extensibilty
{
    public partial class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator+(Point p1, Point p2)
        {
            return new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y};
        }

        public static bool operator==(Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator!=(Point a, Point b)
        {
            return !(a == b);
        }

        partial void Format(int nr)
        {
            System.Console.WriteLine("To String");
        }
    }
}