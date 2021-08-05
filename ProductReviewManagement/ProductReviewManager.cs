using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

namespace ProductReviewManagement
{
    public class ProductReviewManager
    {
        public List<ProductReview> products = new List<ProductReview>();
        DataTable productdt;
        //Usecase 1: Adding a Productreview details
        public int AddingProductReview()
        {
            products.Add(new ProductReview() { productId = 2, userId = 1, review = "Average", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 2, review = "Good", rating = 5, isLike = false});
            products.Add(new ProductReview() { productId = 3, userId = 3, review = "Average", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 5, review = "Good", rating = 5, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Bad", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Bad", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 5, userId = 8, review = "Bad", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Average", rating = 3, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 7, userId = 9, review = "Bad", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 5, review = "Average", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 3, review = "Good", rating = 5, isLike = false });
            products.Add(new ProductReview() { productId = 3, userId = 2, review = "Nice", rating = 4, isLike = false });
            products.Add(new ProductReview() { productId = 8, userId = 9, review = "Bad", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 3, review = "Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 3, review = "Nice", rating = 4, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 15, review = "Nice", rating = 4, isLike = true });
            products.Add(new ProductReview() { productId = 1, userId = 9, review = "Average", rating = 2, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Bad", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 2, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 5, userId = 8, review = "Bad", rating = 1, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Nice", rating = 4, isLike = false });
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
        public string CountingProductId()
        {
            string nameList = "";
            AddingProductReview();
            var productList = products.GroupBy(x => x.productId).Select(a => new { ProductId = a.Key, count = a.Count() });
            foreach (var element in productList)
            {
                Console.WriteLine("ProductId " + element.ProductId + " " + "Count " + " " + element.count);
                nameList += element.count + " ";
            }
            return nameList;
        }

        // Usecase 5: Retrieving the product id and Review from list
        public string RetrieveOnlyProductIdAndReviews()
        {
            string result = "";
            AddingProductReview();
            var productList = products.Select(product => new { ProductId = product.productId, Review = product.review }).ToList();
            foreach (var element in productList)
            {
                Console.WriteLine("ProductId: " + element.ProductId + "\tReview: " + element.Review);
                result += element.ProductId + " ";
            }
            return result;
        }
        //Usecase 6: Skip top Five records
        public string SkipTop5Record()
        {
            AddingProductReview();
            string nameList = "";
            var result = (from product in products orderby product.rating descending select product).Skip(5).ToList();
            foreach(var element in result)
            {
                nameList += element.productId + " ";
            }
            return nameList;
        }
        //Usecase 8: Adding a Productreview details in Data Table
        public int CreateDataTable()
        {
            AddingProductReview();
            productdt = new DataTable();
            productdt.Columns.Add("productId",typeof(Int32));
            productdt.Columns.Add("userId", typeof(Int32));
            productdt.Columns.Add("rating",typeof(Int32));
            productdt.Columns.Add("review", typeof(string));
            productdt.Columns.Add("isLike", typeof(bool));

            foreach (var data in products)
            {
                productdt.Rows.Add(data.productId, data.userId, data.rating, data.review, data.isLike);
            }

            return productdt.Rows.Count;
        }
        // UsecCase 9: Retrieve the records whose column islike has true using DataTable
        public string ReturnsOnlyIsLikeFieldAsTrue()
        {
            List<ProductReview> products = new List<ProductReview>();
            CreateDataTable();
            string nameList = "";
            var res = from product in productdt.AsEnumerable() where product.Field<bool>("isLike") == true select product;
            foreach (var p in res)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", p["productId"], p["userId"], p["rating"], p["review"], p["isLike"]);
                nameList += p["userId"] + " ";
            }
            return nameList;
        }
        //Usecase 10: Average of rating based on ProductId
        public string AverageofRatingBasedonProductId()
        {
            string result = "";
            CreateDataTable();
            var res = from product in productdt.AsEnumerable() group product by product.Field<int>("productId") into temp select new { productid = temp.Key, Average = Math.Round(temp.Average(x => x.Field<int>("rating")), 1) }; 
            foreach (var r in res)
            {
                Console.WriteLine("Product id: {0} Average Rating: {1}",r.productid,r.Average);
                result += r.Average + " ";
            }
            return result;
        }
        //Usecase 11: Retrieve records where review is Nice
        public string ReturnsReviewMessageContainsNice()
        {
            CreateDataTable();
            List<ProductReview> products = new List<ProductReview>();

            string nameList = "";
            var res = from product in productdt.AsEnumerable() where product.Field<string>("review") == "Nice" select product;
            foreach (var p in res)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} | {4} ", p["productId"], p["userId"], p["rating"], p["review"], p["isLike"]);
                nameList += p["userId"] + " ";
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
