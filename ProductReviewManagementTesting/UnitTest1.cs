using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductReviewManagement;
using System.Collections.Generic;

namespace ProductReviewManagementTesting
{
    [TestClass]
    public class UnitTest1
    {

        //Usecase 1: Adding a Productreview details in list and returns the count
        [TestMethod]
        public void GivenCreateFunction_returnCountofListCreated()
        {
            int expected = 25;
            int actual = ProductReviewManager.AddingProductReview();
            Assert.AreEqual(expected, actual);
        }
    }
}
