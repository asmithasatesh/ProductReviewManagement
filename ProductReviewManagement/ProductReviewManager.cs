using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    public class ProductReviewManager
    {
        //Usecase 1: Adding a Productreview details
        public static int AddingProductReview(List<ProductReview> products)
        {
            products.Add(new ProductReview() { productId = 2, userId = 1, review = "Bad", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 5, isLike = false});
            products.Add(new ProductReview() { productId = 3, userId = 3, review = "Nice", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 5, review = "Bad", rating = 7, isLike = false });
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


        public static void DisplayList(List<ProductReview> products)
        {
            foreach (ProductReview product in products)
            {
                Console.WriteLine("ProductId: {0} || UserId: {1} || Review: {2} || Rating: {3} || IsLike:{4}\n", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }
    }
}
