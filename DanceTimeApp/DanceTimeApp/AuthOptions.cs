using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace DanceTimeApp;

public class AuthOptions
{
    public const string Issuer = "AuthServer";
    public const string Audience = "AuthServer";
    private const string Key = "my_secret_key_123";
    public const int LifeTime = 20;

    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
    } 
}