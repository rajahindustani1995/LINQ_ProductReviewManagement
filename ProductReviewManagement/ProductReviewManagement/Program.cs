namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            List<ProductReview> list = ReviewManagement.AddProductsReview();
            ReviewManagement.DisplayeProductsReview(list);
            Console.ReadLine();
        }

    }
}