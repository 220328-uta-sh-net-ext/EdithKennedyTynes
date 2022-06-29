namespace CHModel
{
    public class AdminUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }


        public AdminUser(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}