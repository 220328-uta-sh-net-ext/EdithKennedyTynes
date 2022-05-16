
using CHModel;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ChopHouseAPI.Repository
{
    public class JWTManagerRepo : IJWTManagerRepo
    {/// <summary>
     /// Logic to store Users and Authenticate
     /// the configuration corresponds to the configuration builder services
     /// in program.cs
     /// </summary>
     /// <param name="user"></param>
     /// <returns></returns>
     /// 
        private IConfiguration configuration;

    /// <summary>
    /// Constructor to call and assign the configuration
    /// and instantiate this.configuration
    ///
    /// </summary>
        public JWTManagerRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        Dictionary<string, string> UserRecords = new Dictionary<string, string>()
        {
            {"UserName1", "Password1" },
            {"UserName2", "Password2" },
            {"UserName3", "Password3" },
            {"UserName4", "Password4" },
            {"UserName5", "Password5" }
        };

        /// <summary>
        /// Checking if the user is matching to that in the dictionary 
        /// from database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Token Authenticate(User user)
        {
            if (!UserRecords.Any(a=>a.Key==user.UserName && a.Value == user.Password)) //Lambdas Expression
            {
                return null;
            }
            //else generate JWT Token
            var tokenHandler=new JwtSecurityTokenHandler();
            var tokenKey=Encoding.UTF8.GetBytes(configuration["JWT:KEY"]);

            //token descriptor know as the claims..Boiler plate code?
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject=new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.UserName)
                    }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256), //SecurityAlgorithms.HmacSha256 converts token in unreadable format/encryption for security

            };

            var token=tokenHandler.CreateToken(tokenDescriptor);
            return new Token { ValidToken = tokenHandler.WriteToken(token) };
        }
        

    }

}
