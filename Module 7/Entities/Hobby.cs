namespace Entities
{
    public class Hobby
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<PersonHobby> People { get; set; } = new HashSet<PersonHobby>();
    }
}