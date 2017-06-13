using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class LoginUser
    {
        public LoginUser(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
        public LoginUser(string email)
        {
            this.Email = email;
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
