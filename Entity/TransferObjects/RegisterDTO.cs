namespace Domain.TransferObjects
{
    public class RegisterDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string RepeatPassword { get; set; }
        public int roleId { get; set; } = 1;
    }
}
