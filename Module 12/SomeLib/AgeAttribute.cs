namespace SomeLib
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AgeAttribute : Attribute
    {
        public int MaxAge { get; set; }
    }
}