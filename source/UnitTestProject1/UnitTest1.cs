using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thinktecture.IdentityModel.Client;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Deserialize_Error_Response_With_UppercasePropertyNames()
        {
            var tokenResponse = new TokenResponse("{\"Error\":\"unauthorized_client\",\"ErrorDescription\":null}");

            Assert.AreEqual(true, tokenResponse.IsError);
        }

        [TestMethod]
        public void Deserialize_Error_Response_With_LowercasePropertyNames()
        {
            var tokenResponse = new TokenResponse("{\"error\":\"unauthorized_client\",\"ErrorDescription\":null}");

            Assert.AreEqual(true, tokenResponse.IsError);
        }
    }
}
