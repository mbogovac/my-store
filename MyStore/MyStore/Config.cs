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
                public static string UnregisteredEmail = "mila16@gmail.com";
            }

            public static class Invalid
            {
                public static string Email = "d @gmail.com";
                public static string Password = "bla";
                public static string Empty = "";
            }
        }

        public static class CreateAccountData
        {
            public static class Valid
            {
                public static string FirstName = "Mila";
                public static string LastName = "Bogovac";
                public static string Password = "mila123";
                public static string Address = "Kraljevica Marka 32";
                public static string City = "Miami";
                public static string PostalCode = "11100";
                public static string MobilePhone = "+3816911111";
            }

            public static class Invalid
            {
                public static string Empty = "";
                public static string PassLessThan5 = "123";
            }
        }


        public static class ErrorMessages
        {
            public static string InvalidEmail = "Invalid email address.";
            public static string EmptyEmailField = "An email address required.";
            public static string EmptyPasswordField = "Password is required.";
            public static string ExistingEmail = "An account using this email address has already been registered. Please enter a valid password or request a new one.";
            public static string InvalidPass = "passwd is invalid.";
        }

    }
}
