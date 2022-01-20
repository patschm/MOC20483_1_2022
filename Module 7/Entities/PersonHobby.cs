namespace Entities
{
    public class PersonHobby
    {
        public int PersonId { get; set; }
        public int HobbyId { get; set; }

        public virtual Person? Person { get; set; }
        public virtual Hobby? Hobby { get; set; }
    }
}