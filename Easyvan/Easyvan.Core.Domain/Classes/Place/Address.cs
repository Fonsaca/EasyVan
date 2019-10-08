using Easyvan.Core.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easyvan.Core.Domain.Classes.Place
{
    public class Address : BaseObject
    {
        public string State { get; set; }
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Additional { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
