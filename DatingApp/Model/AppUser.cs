namespace DatingApp.Model
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PaaswordHash { get; set; }
        public byte[] PaaswordSalt { get; set; }
    }
}
