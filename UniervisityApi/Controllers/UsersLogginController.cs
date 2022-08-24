using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniervisityApi.Helpers;
using UniervisityApi.Models.DataModels;

namespace UniervisityApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersLogginController : ControllerBase
    {
        private readonly JwtSettings _jwtSettings;

        private IEnumerable<User> Loggins = new List<User>()
        {
            new User()
            {
                Id = 1,
                Name = "Admin",
                Email="gaby@gmail.com",
                Password= "pepe",

            },
            new User()
            {
                Id = 2,
                Name = "User 1",
                Email="gabycata@gmail.com",
                Password= "castor",

            }
        };
        public UsersLogginController(JwtSettings jwSettings)
        {
            jwSettings = _jwtSettings;
        }

        [HttpPost]
        public IActionResult GetToken(UsersLoggin userLogin)
        {
            try
            {
                var Token = new UserTokens();
                var Valid = Loggins.Any(user => user.Name.Equals(userLogin.UserName, StringComparison.OrdinalIgnoreCase));

                if (Valid)
                {
                    var user = Loggins.FirstOrDefault(user => user.Name.Equals(userLogin.UserName, StringComparison.OrdinalIgnoreCase));
                    Token = JwtHelper.GenTokenKey(new UserTokens()
                    {
                        UserName = user.Name,
                        EmailId = user.Email,
                        Id = user.Id,
                        GuidId = Guid.NewGuid(),
                    }, _jwtSettings);
                }
                else
                {
                    return BadRequest("Wrong Password");
                }
                return Ok(Token);


            }
            catch (Exception ex)
            {

                throw new Exception("GetToken error", ex);
            }
        }
        
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles ="Administrator")]
        public IActionResult GetUserList()
        {
            return Ok(Loggins);
        }
    }
}
