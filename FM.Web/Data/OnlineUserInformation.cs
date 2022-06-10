using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FM.Web.Data
{
    public class OnlineUserInformation
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public int RoleID { get; set; }
        public string TokenID { get; set; }
        public string Message { get; set; }
        public int SelectedHouseID { get; set; }
        public int HouseOwnerID { get; set; }


    }
}
