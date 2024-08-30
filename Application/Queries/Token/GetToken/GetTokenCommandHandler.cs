using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Queries.Token.GetToken
{
    public class GetTokenCommandHandler : IRequestHandler<GetTokenQuery, TokenResponseDto>
    {
        private readonly IConfiguration _configuration;

        public GetTokenCommandHandler(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<TokenResponseDto> Handle(GetTokenQuery request, CancellationToken cancellationToken)
        {
            var tokenString = GenerateJwtToken(CreateDummyClaim());

            return new TokenResponseDto
            {
                Token = tokenString,
                Expiration = DateTime.UtcNow.AddHours(1)
            };
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = CreateTokenDescriptor(user, key);

            var securityToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(securityToken);
        }

        private SecurityTokenDescriptor CreateTokenDescriptor(User user, byte[] key)
        {
            return new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(CreateClaims(user)),
                Expires = DateTime.UtcNow.AddHours(1),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
        }

        private IEnumerable<Claim> CreateClaims(User user)
        {
            return new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new(ClaimTypes.Name, user.UserName),
                new(ClaimTypes.Email, user.UserEmail),
                new("CompanyId", user.CompanyId.ToString())
            };
        }

        private static User CreateDummyClaim()
        {
            return new User
            {
                UserId = Guid.NewGuid(),
                UserName = "dummyUserName",
                UserEmail = "dummy@example.com",
                UserPhone = "123-456-7890",
                CompanyId = 123456
            };
        }
    }
}