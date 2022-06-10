using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DTOs
{
    public class RegisterDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
    }
}
