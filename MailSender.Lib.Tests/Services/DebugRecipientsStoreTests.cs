using System;
using MailSender.Lib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailSender.Lib.Tests.Services
{
    [TestClass]
    public class DebugRecipientsStoreTests
    {
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void Create_throw_ArgumentNullException_if_item_is_null_1()
        {
            var store = new DebugRecipientsStore();
            store.Create(null);
        }

        [TestMethod]
        public void Create_throw_ArgumentNullException_if_item_is_null_2()
        {
            var store = new DebugRecipientsStore();
            Assert.ThrowsException<ArgumentNullException>(() => store.Create(null));
        }
    }
}
