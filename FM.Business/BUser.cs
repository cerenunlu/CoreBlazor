using FM.DataLayer;
using FM.DataLayer.Entities;
using FM.DTOs;
using BC = BCrypt.Net.BCrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FM.Business
{
    public class BUser
    {
        public static List<UserDto> GetUsers()
        {
            using (var uow = new UnitOfWork())
            {
                List<ENTUser> user = uow.UserRepository.GetAll().ToList();
                List<UserDto> listUserDto = new List<UserDto>();
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
                    listUserDto.Add(userDto);
                }
                return listUserDto;
            }
        }
        public static UserDto GetUserByID(int id)
        {
            using (var uow = new UnitOfWork())
            {
                ENTUser user = uow.UserRepository.GetByID(id);
                UserDto userDto = new UserDto();
                userDto.ID = user.ID;
                userDto.Name = user.Name;
                userDto.Surname = user.Surname;
                userDto.Age = user.Age;
                userDto.Gender = user.Gender;
                userDto.RoleID = user.RoleID;
                userDto.Email = user.Email;
                userDto.TokenID = user.TokenID;

                return userDto;
            }

        }

        public static RegisterDto RegisterRequest(RegisterDto registerDto)
        {
            using (var uow = new UnitOfWork())
            {
               
                ENTUser user = new ENTUser();

                user.Name = registerDto.Name;
                user.Surname = registerDto.Surname;
                user.Email = registerDto.EMail;
                user.Age = registerDto.Age;
                user.Gender = registerDto.Gender;
                if (registerDto.RoleID==0 || registerDto.RoleID==null)
                {
                    user.RoleID = 2;
                }
                else if(user.RoleID==1)
                {
                    user.RoleID = 1;
                }
                else
                {
                    user.RoleID = 1;
                }
              
                string passwordHash = BC.HashPassword(registerDto.Password);
                user.Password = passwordHash;
                uow.UserRepository.Add(user);
                registerDto.ID = user.ID;

                return registerDto;



            }

        }


        public static LoginResponseDto LoginRequest(LoginRequestDto loginDto)
        {
            using (var uow = new UnitOfWork())
            {
                ENTUser entUser = uow.UserRepository.GetByEmail(loginDto.Email);

                if(BC.Verify(loginDto.Password, entUser.Password))
                {
                    LoginResponseDto dto = new LoginResponseDto();
                    dto.ID = entUser.ID;
                    dto.Name = entUser.Name;
                    dto.Surname = entUser.Surname;
                    dto.Email = entUser.Email;
                    dto.RoleID = entUser.RoleID;

                    return dto;
                }
                return null;

            }
        }

     
    }
}
