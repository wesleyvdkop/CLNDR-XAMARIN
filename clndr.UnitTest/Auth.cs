using System;
using NUnit.Framework;

namespace clndr.UnitTest
{
    [TestFixture()]
    public class Auth
    {
        [Test()]
        public void Login()
        {
            var username = "Wesley.vanderkop@everbridge.com";
            var password = "Test123";

            Assert.AreSame(username, "Wesley.vanderkop@everbridge.com", "Username is not the same");
            Assert.AreSame(password, "Test123", "Password is not the same");
        }
    }
}
