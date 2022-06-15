using _4_Odev.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace _4_Odev.Helpers
{
    public class CreateJwtTokenHelper
    {
        #region FIELDS

        private readonly IConfiguration _configuration;
        private readonly UserManager<UserEntity> _userManager;
        #endregion

        #region CTOR
        public CreateJwtTokenHelper(IConfiguration configuration, UserManager<UserEntity> userManager) =>
        (_userManager, _configuration) = (userManager, configuration);
        #endregion

        #region METHODS
        public JwtSecurityToken GetToken(List<Claim> claims)
        {
            var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var token = new JwtSecurityToken(
                signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256),
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                expires: DateTime.Now.AddDays(1),
                claims: claims
                );
            return token;
        }
        #endregion


    }
}
