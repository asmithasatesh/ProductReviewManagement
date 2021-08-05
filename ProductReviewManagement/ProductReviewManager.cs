using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewManagement
{
    public class ProductReviewManager
    {
        public List<ProductReview> products = new List<ProductReview>();
        //Usecase 1: Adding a Productreview details
        public int AddingProductReview()
        {
            products.Add(new ProductReview() { productId = 2, userId = 1, review = "Bad", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 5, isLike = false});
            products.Add(new ProductReview() { productId = 3, userId = 3, review = "Nice", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 5, review = "Bad", rating = 5, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Nice", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 5, userId = 8, review = "Average", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 3, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 7, userId = 9, review = "Good", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 5, review = "Good", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 3, review = "Bad", rating = 5, isLike = false });
            products.Add(new ProductReview() { productId = 3, userId = 2, review = "Bad", rating = 4, isLike = false });
            products.Add(new ProductReview() { productId = 8, userId = 9, review = "Average", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 3, review = "Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 3, review = "Bad", rating = 4, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 15, review = "Good", rating = 4, isLike = true });
            products.Add(new ProductReview() { productId = 1, userId = 9, review = "Bad", rating = 2, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Good", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 5, userId = 8, review = "Average", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 4, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 3, isLike = true });

            return products.Count;
        }

        // UseCase 2: Retrieve Top Three Records Whose Rating is High
        public int RetrieveTopThreeRating()
        {
            AddingProductReview();
            Console.WriteLine("\n-------- Retrieve Top Three Records Whose Rating is High --------");
            var res = (from product in products orderby product.rating descending select product).Take(3).ToList();
            DisplayList();
            return res.Count;
        }
        // Usecase 3: Retrieve  records from list based on productid and rating > 3  
        public string RetrieveRecordsBasedOnRatingAndProductId()
        {
            AddingProductReview();
            string nameList = "";
            Console.WriteLine("\n-----------Retrieve Records Based On Rating and Product Id-----------");
            var productList = (from product in products where product.rating > 3 && (product.productId == 1 || product.productId == 4 || product.productId == 9) select product);
            foreach(var product in productList)
            {
                nameList += product.userId + " ";
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
            return nameList;
        }

        //Display List Content
        public void DisplayList()
        {
            Console.WriteLine("\n-------- Displaying List Content --------\n");
            foreach (ProductReview product in products)
            {
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }
    }
}
