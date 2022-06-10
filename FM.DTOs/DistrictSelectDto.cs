using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DTOs
{
    public class DistrictSelectDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CityID { get; set; }
        public bool isSelected { get; set; }
    }
}
