namespace Extensibilty
{
    public partial class Point
    {      
        partial void Format(int a);
       
        public override string ToString()
        {
            Format(42);
            return $"({X}, {Y})";
        }
        public override bool Equals(object? obj)
        {
            Point? p = (Point)obj!;
            return p! == this;
        }
        public override int GetHashCode()
        {
            return (X + Y).GetHashCode();
        }
    }
}