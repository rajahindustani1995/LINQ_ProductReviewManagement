﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ReviewManagement
    {
        public static List<ProductReview> AddProductsReview()
        {
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ ProductID=1,UserID=34,Review="Good",IsLike=true,Rating=4.5 },
                new ProductReview(){ ProductID=4,UserID=23,Review="Bad",IsLike=false,Rating=1.5 },
                new ProductReview(){ ProductID=5,UserID=39,Review="Good",IsLike=true,Rating=3.5 },
                new ProductReview(){ ProductID=8,UserID=57,Review="Average",IsLike=true,Rating=3.5 },
                new ProductReview(){ ProductID=1,UserID=78,Review="Good",IsLike=true,Rating=3.5 },
                new ProductReview(){ ProductID=7,UserID=22,Review="Average",IsLike=true,Rating=3.0 },
                new ProductReview(){ ProductID=9,UserID=11,Review="Good",IsLike=true,Rating=3.9 },
                new ProductReview(){ ProductID=3,UserID=45,Review="Bad",IsLike=false,Rating=2.5 },
                new ProductReview(){ ProductID=6,UserID=89,Review="Good",IsLike=true,Rating=3.5 },
                new ProductReview(){ ProductID=2,UserID=24,Review="Good",IsLike=true,Rating=4.8 },
                new ProductReview(){ ProductID=7,UserID=10,Review="Bad",IsLike=false,Rating=2.0 },
                new ProductReview(){ ProductID=8,UserID=34,Review="Average",IsLike=true,Rating=3.8 },
                new ProductReview(){ ProductID=6,UserID=18,Review="Good",IsLike=true,Rating=3.5 },
                new ProductReview(){ ProductID=5,UserID=62,Review="Average",IsLike=true,Rating=3.0 },
                new ProductReview(){ ProductID=3,UserID=51,Review="Good",IsLike=true,Rating=3.9 },
                new ProductReview(){ ProductID=7,UserID=35,Review="Bad",IsLike=false,Rating=2.5 }
            };

            return list;
        }
        public static void DisplayeProductsReview(List<ProductReview> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        //UC-2
        public static void RetrieveTop3Reviews(List<ProductReview> list)
        {
            Console.WriteLine("Retrieving Top 3 products based on rating");
            var sortedProduct = from product in list orderby product.Rating descending select product;
            var top3 = sortedProduct.Take(3).ToList();
            DisplayeProductsReview(top3);
        }

        //UC-3
        public static void RatingGreaterThan3(List<ProductReview> list)
        {
            Console.WriteLine("Retrieving products based on rating greater than 3 and having ProductID as 1/4/9");
            var res1 = list.Where(p => p.Rating > 3 && (p.ProductID == 1 || p.ProductID == 4 || p.ProductID == 9)).ToList();
            DisplayeProductsReview(res1);
        }
    }
}
