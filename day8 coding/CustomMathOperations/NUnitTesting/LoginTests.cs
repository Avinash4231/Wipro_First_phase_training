using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomMathOperations;

namespace NUnitTesting
{
    [TestFixture]
    public class LoginTests
    {
        private Login login;

        [SetUp]
        public void Setup()
        {
            login = new Login();
        }

        [Test]
        public void Check_Username_Null()
        {
            string result = login.DoLogin(null, "admin");
            Assert.That(result, Is.EqualTo("Username and password cannot be empty"));
        }

        [Test]
        public void Check_Password_Null()
        {
            string result = login.DoLogin("admin", null);
            Assert.That(result, Is.EqualTo("Username and password cannot be empty"));
        }

        [Test]
        public void Check_Invalid_Credentials()
        {
            string result = login.DoLogin("user", "password");
            Assert.That(result, Is.EqualTo("Invalid credentials"));
        }

        [Test]
        public void Check_Login_Successful()
        {
            string result = login.DoLogin("admin", "admin");
            Assert.That(result, Is.EqualTo("Login successful"));
        }
    }
}
