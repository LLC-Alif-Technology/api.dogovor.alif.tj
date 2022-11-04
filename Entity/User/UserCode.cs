namespace Domain.User
{
    public class UserCode
    {
        public int Id { get; set; }
        public string RandomNumber { get; set; }
        public DateTime? ValidDate { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
