using BusinessObject.Entity;
using BusinessObject.Model.JwtTokenModel;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SFB_WebApi
{
    public class JwtTokenGenerator
    {
        private readonly JwtConfig _jwtConfig;

        public JwtTokenGenerator(IConfiguration configuration)
        {
            _jwtConfig = new JwtConfig
            {
                Key = configuration["JwtConfig:Key"]!,
                Issuer = configuration["JwtConfig:Issuer"]!,
                Audience = configuration["JwtConfig:Audience"]!
            };
        }

        public string GenerateToken(TokenModel model)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Key));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(CustomerClaimType.UserID, model.UserID.ToString()),
                new Claim(CustomerClaimType.UserName, model.UserName),
                new Claim(CustomerClaimType.Email, model.Email),
                new Claim(CustomerClaimType.RoleID, model.RoleID.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(60), // hoặc lấy từ config nếu bạn muốn
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
