using BasicApi.Controllers;
using System;
using Xunit;

namespace ApiTest
{
    public class NameControllerFixtures
    {
        [Fact]
        public void Test_For_Simple_hello_with_name()
        {
            {
             
                NamesController nc = new NamesController();
                Assert.Equal("Hi shubham", nc.Get("shubham"));

            }

        }
    }
}
