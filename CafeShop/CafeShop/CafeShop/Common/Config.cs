namespace CafeShop.Common
{
    public static class Config
    {
        public static string Connection()
        {
            string conn = "Data Source=CHUVANQUY\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True;Trust Server Certificate=True";
            return conn;
        }

        public static string ImageUrl()
        {
            string imageUrl = @"https://localhost:44368/images/";
            return imageUrl;
        }

    }
}
