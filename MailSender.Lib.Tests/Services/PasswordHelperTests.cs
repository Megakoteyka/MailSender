using System.Diagnostics;
using MailSender.Lib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailSender.Lib.Tests.Services
{
    [TestClass]
    public class PasswordHelperTests
    {
        [TestMethod]
        public void TestEncode_1TM_to_8o1_with_key_7()
        {
            const string text = "1TM";
            const int key = 7;
            
            const string expectedText = "8o1";

            var actualText = text.Encode(key);

            Assert.AreEqual(actualText, expectedText);
        }

        [TestMethod]
        public void TestDecode_8o1_to_1TM_with_key_7()
        {
            const string text = "8o1";
            const int key = 7;
            
            const string expectedText = "1TM";

            var actualText = text.Decode(key);

            Assert.AreEqual(actualText, expectedText);
        }

        #region InitializeAndCleanup
        
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Debug.WriteLine("PasswordHelperTests.AssemblyInitialize");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Debug.WriteLine("PasswordHelperTests.ClassInitialize");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("PasswordHelperTests.TestInitialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("PasswordHelperTests.TestCleanup");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("PasswordHelperTests.ClassCleanup");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("PasswordHelperTests.AssemblyCleanup");
        }
        #endregion
    }
}
