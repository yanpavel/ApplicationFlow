using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Apply
{
    public class AuthTestBase:TestBase
    {
        [SetUp]
        public void SetupLogin()
        {
            app.Auth.Login(new AccountData("pmrlogin@test.ru", "Qwerty002!"));
        }
    }
}
