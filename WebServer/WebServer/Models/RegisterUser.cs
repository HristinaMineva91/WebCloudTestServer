using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class RegisterUser
    {
        public RegisterUser(string instagramUsername, string password, string confirmPassword, string email)
        {
            this.InstagramUsername = instagramUsername;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
            this.Email = email;
        }
        public string InstagramUsername { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
    }
}
