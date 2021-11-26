using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class PWTest
    {
        [Test,
            TestCase("abcd1234", false),
    TestCase("irf@uni-corvinus", false),
    TestCase("irf.uni-corvinus.hu", false),
    TestCase("irf@uni-corvinus.hu", true)
            ]
        public void TestValidatePW(string pw, bool expectedResult)
        {

            var accountController = new AccountController();


            var actualResult = accountController.ValidatePassword(pw);


            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
