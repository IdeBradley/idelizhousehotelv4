//  Separate for debugging purposes.   Eventually will be moved out of this app into a client library to be shared with the web apps
//  All fields match the fields in the SQL Azure database
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happyhouse
{
    class Reservation
    {
        public string ReservationID { get; set; }
        public string PropertyID { get; set; }
        public string ClientID { get; set; }
        public string BookingStatus { get; set; }
        public string TimeSegment { get; set; }
        public Nullable<bool> Deposit_Received { get; set; }
    
        public virtual Property Property { get; set; }
    }
}
