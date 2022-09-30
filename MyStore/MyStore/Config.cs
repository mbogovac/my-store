namespace MyStore
{
    public static class Config
    {
        public static string BaseUrl = "http://automationpractice.com/index.php?";

        public static class Credentials
        {
            public static class Valid
            {
                public static string Email = "delboy@gmail.com";
                public static string Password = "12345";
            }

            public static class Invalid
            {
                public static string Email = "d @gmail.com";
                public static string Password = "bla";
            }

        }
    }
}
