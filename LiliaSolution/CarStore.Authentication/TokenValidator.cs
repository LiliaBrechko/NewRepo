using System.IdentityModel.Tokens.Jwt;
using System.Text;
using CarStore.Authentication;
using Microsoft.IdentityModel.Tokens;

public class TokenValidator
{
    public bool ValidateToken(string token)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(TokenService.SecretKey);

        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            // Дополнительная проверка данных токена, если необходимо
            var jwtToken = (JwtSecurityToken)validatedToken;
            var username = jwtToken.Claims.First(x => x.Type == "unique_name").Value;

            // Например, проверить наличие пользователя в базе
            return !string.IsNullOrEmpty(username);
        }
        catch
        {
            return false; // Токен недействителен
        }
    }
}