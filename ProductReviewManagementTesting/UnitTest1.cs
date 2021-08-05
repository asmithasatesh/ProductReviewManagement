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

        //Usecase 3: Retrieve records from list based on productid and rating > 3 
        [TestMethod]
        public void TestMethodForRetrieveRecordsBasedOnRatingAndProductId()
        {
            string expected = "7 3 3 15 7 ";
            string actual = productManager.RetrieveRecordsBasedOnRatingAndProductId();
            Assert.AreEqual(expected, actual);
        }
        /// Usecase 4: Retrived the count based on productId
        [TestMethod]
        public void TestMethodForCountingProductId()
        {
            string expected = "6 4 4 3 4 1 2 1 ";
            string actual = productManager.CountingProductId();
            Assert.AreEqual(expected, actual);
        }
        /// Usecase 5: Retrieving the product id and Review from list
        [TestMethod]
        public void TestMethodForProductId()
        {
            string expected = "2 2 3 2 1 2 4 5 3 5 7 9 4 3 8 2 9 1 1 1 2 4 5 3 5 ";
            string actual = productManager.RetrieveOnlyProductIdAndReviews();
            Assert.AreEqual(expected, actual);
        }
        //Usecase 6: Skip top Five records
        [TestMethod]
        public void givenRecords_SkipTopFiveandReturn()
        {
            string expected = "4 3 9 1 3 3 5 5 2 3 9 1 2 1 2 5 7 8 1 5 ";
            string actual = productManager.SkipTop5Record();
            Assert.AreEqual(expected, actual);
        }
        //Usecase 8: Adding a Productreview details in Data Table
        [TestMethod]
        public void GivenCreateFunctionforDT_returnCountofListCreated()
        {
            int expected = 25;
            int actual = productManager.CreateDataTable();
            Assert.AreEqual(expected, actual);
        }
    }
}
