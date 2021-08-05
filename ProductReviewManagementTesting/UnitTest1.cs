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
        [TestCategory("Using LINQ in List")]
        public void GivenCreateFunction_returnCountofListCreated()
        {
            int expected = 25;
            int actual = productManager.AddingProductReview();
            Assert.AreEqual(expected, actual);
        }
        // UseCase 2: Retrieve Top Three Records Whose Rating is High
        [TestMethod]
        [TestCategory("Using LINQ in List")]
        public void TestMethodForRetrieveTopThreeRecord()
        {
            int expected = 3;
            var actual = productManager.RetrieveTopThreeRating();
            Assert.AreEqual(expected, actual);
        }

        //Usecase 3: Retrieve records from list based on productid and rating > 3 
        [TestMethod]
        [TestCategory("Using LINQ in List")]
        public void TestMethodForRetrieveRecordsBasedOnRatingAndProductId()
        {
            string expected = "7 3 3 15 7 ";
            string actual = productManager.RetrieveRecordsBasedOnRatingAndProductId();
            Assert.AreEqual(expected, actual);
        }
        /// Usecase 4: Retrived the count based on productId
        [TestMethod]
        [TestCategory("Using LINQ in List")]
        public void TestMethodForCountingProductId()
        {
            string expected = "6 4 4 3 4 1 2 1 ";
            string actual = productManager.CountingProductId();
            Assert.AreEqual(expected, actual);
        }
        /// Usecase 5: Retrieving the product id and Review from list
        [TestMethod]
        [TestCategory("Using LINQ in List")]
        public void TestMethodForProductId()
        {
            string expected = "2 2 3 2 1 2 4 5 3 5 7 9 4 3 8 2 9 1 1 1 2 4 5 3 5 ";
            string actual = productManager.RetrieveOnlyProductIdAndReviews();
            Assert.AreEqual(expected, actual);
        }
        //Usecase 6: Skip top Five records
        [TestMethod]
        [TestCategory("Using LINQ in List")]
        public void givenRecords_SkipTopFiveandReturn()
        {
            string expected = "4 3 9 1 3 3 5 5 2 3 9 1 2 1 2 5 7 8 1 5 ";
            string actual = productManager.SkipTop5Record();
            Assert.AreEqual(expected, actual);
        }
        //Usecase 8: Adding a Productreview details in Data Table
        [TestMethod]
        [TestCategory("Using LINQ in DataTable")]
        public void GivenCreateFunctionforDT_returnCountofListCreated()
        {
            int expected = 25;
            int actual = productManager.CreateDataTable();
            Assert.AreEqual(expected, actual);
        }

        // UsecCase 9: Retrieve the records whose column islike has true using DataTable
        [TestMethod]
        [TestCategory("Using LINQ in DataTable")]
        public void TestMethodForReturnsOnlyIsLikeFieldAsTrue()
        {
            string expected = "1 3 1 6 7 8 4 9 5 9 3 15 1 6 7 8 4 ";
            string actual = productManager.ReturnsOnlyIsLikeFieldAsTrue();
            Assert.AreEqual(expected, actual);
        }
        //Usecase 10: Average of rating based on ProductId
        [TestMethod]
        [TestCategory("Using LINQ in DataTable")]
        public void TestMethodForReturns_AverageofRating()
        {
            string expected = "3.3 3.2 2 5 2 1 3 1 ";
            string actual = productManager.AverageofRatingBasedonProductId();
            Assert.AreEqual(expected, actual);
        }
        //Usecase 11: Retrieve records where review is Nice
        [TestMethod]
        [TestCategory("Using LINQ in DataTable")]
        public void TestMethodForReviewReturnsString()
        {
            string expected = "2 3 15 9 ";
            string actual = productManager.ReturnsReviewMessageContainsNice();
            Assert.AreEqual(expected, actual);
        }
    }
}
