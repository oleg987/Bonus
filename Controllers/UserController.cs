using Microsoft.AspNetCore.Mvc;

namespace Bonus.Controllers
{
    public record UserSignUpRequest(string Login, string Password);
    public record UserSignInRequest(string Login, string Password);
    public record BuyShitRequest(string Login, string Password, long Count);

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult SignUp(UserSignUpRequest model)
        {
            /*
             * Register User.
             * Save User into DB.
             * Every 10 seconds after registration User achive 1 Bonus.
             */
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult UserInfo(UserSignInRequest model)
        {
            /*
             * Show info about User(Login, Bonuses, Coins, EyeLength)
             */
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult BuyShit(UserSignInRequest model)
        {
            /*
             * User can buy ShitCoins.
             * Price of 1 ShitCoin = 100 Bonus.
             * Every ShitCoin every 1 minutes increases EyeLength by 1.
             */
            throw new NotImplementedException();
        }
    }
}
