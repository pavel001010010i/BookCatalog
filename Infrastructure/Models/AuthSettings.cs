namespace Infrastructure
{
    public class AuthSettings
    {
        public string SecretKey { get; set; }

        public string Audience { get; set; }

        public string Issuer { get; set; }

        public double ExpirationDays { get; set; }
    }
}
