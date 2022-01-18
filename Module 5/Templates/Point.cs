namespace Templates
{
    public class Point<T>
    {
        public T? X { get; set; }
        public T? Y { get; set; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}