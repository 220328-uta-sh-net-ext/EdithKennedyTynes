using Microsoft.IdentityModel.Tokens;
using CHModel;
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
            this.configuration = configuration;//instantiating configuration
        }
        Dictionary<string, string> UserRecords = new Dictionary<string, string>
        {
            {"User1", "Password1" },
            {"ChopHouseAdmin", "Admin123" },
            {"AdminUser", "Password3" },
            {"User4", "AdminPassword4" },
            {"User5", "Password5" }
        };

        /// <summary>
        /// Checking 'if' the user is matching to that in the dictionary 
        /// from database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Token Authenticate(AdminUser aduser)
        {
            if (!UserRecords.Any(a => a.Key == aduser.UserName && a.Value == aduser.Password)) //Lambdas Expression
            {
                return null;
            }       
            //else generate JWT Token if username and password match
            var tokenhandler=new JwtSecurityTokenHandler();
            var tokenKey=Encoding.UTF32.GetBytes(configuration["JWT:Key"]);

            //token descriptor know as the claims..Boiler plate code?
            /// <summary>
            /// configuration set to create a token
            /// </summary>
            /// <returns>new token created to be returned in UserController</returns>

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject=new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, aduser.UserName)
                    }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256), //SecurityAlgorithms.HmacSha256 converts token in unreadable format/encryption for security

            };
            //creating token and storing it in var
            var token=tokenhandler.CreateToken(tokenDescriptor);
            return new Token { RToken = tokenhandler.WriteToken(token) };//method returns token
        }
        

    }

}
