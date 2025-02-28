using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMathOperations
{
    public class Login
    {
        public string DoLogin(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Username and password cannot be empty";
            }

            if (username == "admin" && password == "admin")
            {
                return "Login successful";
            }

            return "Invalid credentials";
        }
    }

}
