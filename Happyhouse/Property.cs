//  Property class for mobile app.   Long term this would be moved into a client library for this and the other web apps.
//  It's separate here for debugging purposes in case anything needs to change
//  All fields identical to the SQL Azure database

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happyhouse
{
    class Property
    {
       public Property()
       {
           this.Reservations = new HashSet<Reservation>();
       }

        public string PropertyID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Unit_description { get; set; }
        public string Number_of_Bedrooms { get; set; }
        public string Price_mid_season { get; set; }
        public string Availability { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
