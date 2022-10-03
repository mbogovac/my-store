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
                public static string UnregisteredEmail = "mila12@gmail.com";
            }

            public static class Invalid
            {
                public static string Email = "d @gmail.com";
                public static string Password = "bla";
                public static string Empty = "";
            }
        }

        public static class ErrorMessages
        {
            public static string InvalidEmail = "Invalid email address.";
            public static string EmptyEmailField = "An email address required.";
            public static string EmptyPasswordField = "Password is required.";
            public static string ExistingEmail = "An account using this email address has already been registered. Please enter a valid password or request a new one.";
        }

    }
}
