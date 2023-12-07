using Microsoft.VisualStudio.TestTools.UnitTesting;
using Push.DataAccess.Analytics;

namespace Push.DataAccess.Analytics.Test
{
    [TestClass]
    public class WhenReadingData
    {
        [TestMethod]
        public void Can_get_dbConnection()
        {
            TestAccess testAccess = new TestAccess();
            bool testdb = testAccess.CheckDbConnection();

            Assert.AreEqual(true, testdb);
        }
    }
}
