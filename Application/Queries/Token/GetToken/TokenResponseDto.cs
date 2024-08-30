namespace Application.Queries.Token.GetToken
{
    public class TokenResponseDto
    {

        public string Token { get; set; }
        public string TokenType { get; set; } = "Bearer";
        public DateTime Expiration { get; set; }
    }
}