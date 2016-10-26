using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelocityCoders.FitnessSchedule.Models;
using Uhler.Common;

namespace VelocityCoders.FitnessSchedule.Models
{
    public class Location /*: BaseEntity<int>*/
    {
        public Location(string locationName, string address01, string address02, string city, int zipCode, int zipCodePlusFour)
        {
            this.LocationName = locationName;
            this.Address01 = address01;
            this.Address02 = address02;
            this.City = city;
            this.ZipCode = zipCode;
            this.ZipCodePlusFour = zipCodePlusFour;
        }
        public int LocationId { get; set; }
        public int StateId { get; set; }
        public int GymId { get; set; }
        public string LocationName { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public int ZipCodePlusFour { get; set; }

        public Location()
        {
        }
    }
}
