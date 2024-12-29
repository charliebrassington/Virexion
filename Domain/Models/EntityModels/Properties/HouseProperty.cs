using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.EntityModels.Properties
{
    public class HouseProperty
    {
        public int NumberOfBedrooms { get; set; }
        public int NumberOfToilets { get; set; }
        public float? MonthlyRent {  get; set; }
    }
}
