using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace GhasDemoApi.Services
{
   

    public class JwtService
    {
        // ❌ Secret scanning
        private const string JwtKey = "sk_live_1234567890SUPERSECRET";

        public SymmetricSecurityKey GetKey()
            => new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(JwtKey));
    }
}
