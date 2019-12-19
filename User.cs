namespace AppTests.ModelsGUI
{
    public class User
    {
        public string Login { get; set; }
        public string FIO { get; set; }
        public string Password { get; set; }

        public User()  // конструктор по умолчанию
        {
        }   
        
        public User(string login, string fio, string password)
            : this()
        {
            FIO = fio;
            Login = login;
            Password = password;
        }

    }
}
