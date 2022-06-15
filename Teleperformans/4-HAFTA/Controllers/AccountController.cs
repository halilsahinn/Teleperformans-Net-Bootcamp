using _4_Odev.Contexts;
using _4_Odev.Entities;
using _4_Odev.Helpers;
using _4_Odev.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace _4_Odev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        #region FIELDS
        private readonly SocialMediaContext _context;
        List<Claim> claims = new List<Claim>();
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _iConfiguration;
        CreateJwtTokenHelper jwtTokenHelper;
        private readonly IMemoryCache _memoryCache;
        private readonly IDistributedCache _distributedCache;

        public AccountController(SocialMediaContext context, List<Claim> claims, UserManager<UserEntity> userManager, RoleManager<IdentityRole> roleManager, CreateJwtTokenHelper jwtTokenHelper, IMemoryCache memoryCache, IDistributedCache distributedCache, IConfiguration iConfiguration)
        {
            _context = context;
            this.claims = claims;
            _userManager = userManager;
            _roleManager = roleManager;
            this.jwtTokenHelper = jwtTokenHelper;
            _memoryCache = memoryCache;
            _distributedCache = distributedCache;
            _iConfiguration = iConfiguration;
        }

        #endregion

        #region CTOR



        #endregion

        /*
        #region METHODS
        [HttpGet("GetMessageHistoryCache")]
        [ResponseCache(Duration = 1000, VaryByHeader = "MessageHistory", VaryByQueryKeys = new string[] { "messageHistoryId" })]
        public IEnumerable<MessageHistoryEntity> GetMessageHistory(int messageHistoryId)
        {
            MessageHistoryEntity[] messageHistory = _context.MessageHistory.Where(x => x.MessageId == messageHistoryId).ToArray();
            if (_memoryCache.TryGetValue("messageHistory", out messageHistory))
            {
                return messageHistory;
            }
            var _messageHistory = _distributedCache.Get("messageHistory");
            var messageHistoryJson = Encoding.UTF8.GetString(_messageHistory);
            var messageHistoryArr = JsonSerializer.Deserialize<MessageHistoryEntity[]>(messageHistoryJson);

            MemoryCacheEntryOptions memoryCacheEntryOptions = new MemoryCacheEntryOptions();
            memoryCacheEntryOptions.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(10);
            memoryCacheEntryOptions.SlidingExpiration = TimeSpan.FromHours(3);
            memoryCacheEntryOptions.Priority = CacheItemPriority.Normal;

            _memoryCache.Set("messageHistory", messageHistory, memoryCacheEntryOptions);
            var distMessageHistoryArr = JsonSerializer.Serialize(messageHistory);
            _distributedCache.Set("messageHistory", Encoding.UTF8.GetBytes(distMessageHistoryArr));
            return _messageHistory;
        }
        #endregion
         */

        #region IACTION RESULTS
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel loginViewModel)
        {
            var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (user == null) throw new Exception("");

            var result = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
            if (result)
            {
                var roles = await _userManager.GetRolesAsync(user);
                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
                claims.Add(new Claim(ClaimTypes.Name, user.Email));
                claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
                var token =  jwtTokenHelper.GetToken(claims);
                var handler = new JwtSecurityTokenHandler();
                string jwt = handler.WriteToken(token);
                return Ok(new
                {
                    token = jwt,
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }
        #endregion

    }
}
