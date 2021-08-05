using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

namespace ProductReviewManagementTesting
{
    [TestClass]
    public class UnitTest1
    {
        ProductReviewManager productManager;

        [TestInitialize]
        public void SetUp()
        {
            productManager = new ProductReviewManager();
        }

        //Usecase 1: Adding a Productreview details in list and returns the count
        [TestMethod]
        public void GivenCreateFunction_returnCountofListCreated()
        {
            int expected = 25;
            int actual = productManager.AddingProductReview();
            Assert.AreEqual(expected, actual);
        }
        // UseCase 2: Retrieve Top Three Records Whose Rating is High
        [TestMethod]
        public void TestMethodForRetrieveTopThreeRecord()
        {
            int expected = 3;
            var actual = productManager.RetrieveTopThreeRating();
            Assert.AreEqual(expected, actual);
        }
    }
}
