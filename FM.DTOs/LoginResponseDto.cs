using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DTOs
{
    public class LoginResponseDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TokenID { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public int RoleID { get; set; }
      

    }
}
