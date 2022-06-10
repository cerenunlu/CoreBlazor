using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Text;
using FM.Business;
using FM.DataLayer;
using FM.DTOs;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;

namespace FM.API.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration configuration;
        public UserController(IConfiguration Configuration)
        {
            configuration = Configuration;
        }

        [HttpGet("GetAllUser")]
        public List<UserDto> GetAll()
        {
            var user = BUser.GetUsers();
            List<UserDto> listUser = new List<UserDto>();
            foreach (var item in user)
            {

                UserDto userDto = new UserDto()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Surname = item.Surname,
                    Email = item.Email,
                    Age = item.Age,
                    Gender = item.Gender,
                    Password = item.Password,
                    RoleID = item.RoleID
                };
                listUser.Add(userDto);


            }

            return listUser;

        }

        [HttpGet("GetById/{id}")]
        public UserDto GetByID(int id)
        {
            var user = BUser.GetUserByID(id);
            return user;
        }

        [HttpPost("Register")]
        public ApiResponseDto<LoginResponseDto> Register(RegisterDto registerDto)
        {

            var user = BUser.RegisterRequest(registerDto);
            LoginResponseDto loginResponse = new LoginResponseDto();
            if (user != null)
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecurityKey"]));
                var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expiry = DateTime.Now.AddDays(int.Parse(configuration["JwtExpiryInDays"].ToString()));

                var claims = new[]
                {
                new Claim(ClaimTypes.Email,registerDto.EMail),

            };
                var token = new JwtSecurityToken(configuration["JwtIssuer"], configuration["JwtAudience"], claims, null, expiry, cred);
                string tokenStr = new JwtSecurityTokenHandler().WriteToken(token);
                LoginResponseDto login = new LoginResponseDto()
                {

                    ID = user.ID,
                    Name = user.Name,
                    Surname = user.Surname,
                    TokenID=tokenStr,
                    Email=user.EMail,
                    RoleID=user.RoleID,
                    Age=user.Age,
                    Gender=user.Gender,
                    
                   
                };
                
                return ApiResponseDto<LoginResponseDto>.SuccessResponse(login, "success");


            }
            return ApiResponseDto<LoginResponseDto>.FailedResponse("basarisiz");
        }

        [HttpPost("Login")]

        public ApiResponseDto<LoginResponseDto> Login(LoginRequestDto userLogin)
        {
            var loginUser = BUser.LoginRequest(userLogin);

            if (loginUser != null)
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSecurityKey"]));
                var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var expiry = DateTime.Now.AddDays(int.Parse(configuration["JwtExpiryInDays"].ToString()));

                var claims = new[]
                {
                new Claim(ClaimTypes.Email,userLogin.Email),

            };
                var token = new JwtSecurityToken(configuration["JwtIssuer"], configuration["JwtAudience"], claims, null, expiry, cred);
                string tokenStr = new JwtSecurityTokenHandler().WriteToken(token);
                loginUser.TokenID = tokenStr;
                return ApiResponseDto<LoginResponseDto>.SuccessResponse(loginUser, "success");

            }
            else
            {
                return ApiResponseDto<LoginResponseDto>.FailedResponse("fail");
            }

        }


    }

}
