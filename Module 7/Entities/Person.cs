namespace Entities;
public class Person
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }

    public ICollection<PersonHobby> Hobbies { get; set; } = new HashSet<PersonHobby>();
}
