namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management");
            List<ProductReview> list = ReviewManagement.AddProductsReview();
            Console.WriteLine("1:Add review to the list");
            Console.WriteLine("2:Retrieve Top3 Reviews from the list");
            Console.WriteLine("Choose Option or press 0 for exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ReviewManagement.DisplayeProductsReview(list);
                    break;
                case 2:
                    ReviewManagement.RetrieveTop3Reviews(list);
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadLine();

        }

    }
}