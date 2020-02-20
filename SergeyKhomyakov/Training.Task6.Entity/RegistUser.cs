using System;

namespace Training.Task6.Entity
{
    public class RegistUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string[] Role { get; set; }
    }
}
