using Microsoft.VisualStudio.TestTools.UnitTesting;
using Push.DataAccess.Analytics;

namespace Push.DataAccess.Analytics.Test
{
    [TestClass]
    public class When_FacebookReactionsData
    {
        [TestMethod]
        public void When_GetFacebookReactionsList()
        {
            FacebookReactionsData facebookReactionsData = new FacebookReactionsData();
            string videoId = "614662146495640";
            var results = facebookReactionsData.GetFacebookReactionsList(videoId);
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void When_GetFacebookReaction()
        {
            FacebookReactionsData facebookReactionsData = new FacebookReactionsData();
            string videoId = "614662146495640";
            var results = facebookReactionsData.GetFacebookReaction(videoId);
            Assert.IsNotNull(results);
        }
    }
}
