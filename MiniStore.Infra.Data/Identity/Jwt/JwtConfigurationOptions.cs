namespace MiniStore.Infra.Data.Identity.Jwt
{
    public class JwtConfigurationOptions
    {
        public string? Key { get; set; }
        public string? Audience { get; set; }
        public string? Issuer { get; set; }
        public int ExpireHours { get; set; }
    }
}
