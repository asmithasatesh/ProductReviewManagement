using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

namespace ProductReviewManagementTesting
{
    [TestClass]
    public class UnitTest1
    {
        List<ProductReview> productList;
        [TestInitialize]
        public void SetUp()
        {
            productList = new List<ProductReview>();
        }

        //Usecase 1: Adding a Productreview details in list and returns the count
        [TestMethod]
        public void GivenCreateFunction_returnCountofListCreated()
        {
            int expected = 25;
            int actual = ProductReviewManager.AddingProductReview(productList);
            Assert.AreEqual(expected, actual);
        }

    }
}
