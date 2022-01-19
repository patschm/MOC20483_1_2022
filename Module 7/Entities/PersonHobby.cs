namespace Entities
{
    public class PersonHobby
    {
        public int PersonId { get; set; }
        public int HobbyId { get; set; }

        public Person? Person { get; set; }
        public Hobby? Hobby { get; set; }
    }
}