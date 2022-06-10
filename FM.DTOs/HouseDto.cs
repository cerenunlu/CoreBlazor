using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DTOs
{
    public class HouseDto
    {
        public int ID { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string Size { get; set; }
        public string Period { get; set; }
        public string MovingIn { get; set; }
        public string Address { get; set; }
        public string Deposit { get; set; }
        public int SampleCriteriaID { get; set; }
        public int SampleFacilityID { get; set; }
        public int CityID { get; set; }
        public int Pay { get; set; }
        public int DistrictID { get; set; }
        public int UserID { get; set; }
    }
}
