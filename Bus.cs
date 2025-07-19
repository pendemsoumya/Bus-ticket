using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Transport
{
    internal class Bus : Vehicle
    {
        public string ReservationClass { get; set; }
        public int ServiceNumber { get; set; }
        public Bus(string reservationClass, int serviceNumber, string s, string d, int di, int dur)
        {
            ReservationClass = reservationClass;
            ServiceNumber = serviceNumber;
            Source = s;
            Destination = d;
            Duration = dur;
            Distance = di;
        }
        public string GeneratorBusId()
        {
            string f = Source.Substring(0, 1).ToUpper();
            string d = Destination.Substring(0, 1).ToUpper();
            string sn = "";
            if (ServiceNumber < 10)
            {
                sn = "00" + ServiceNumber;
            } else if (ServiceNumber < 100)
            {
                sn = "00" + ServiceNumber;
            }
            else
            {
                sn = " " + ServiceNumber;
            }
            return f + d + "-" + sn;

        }
        public string GeneratingBusName()
        {
        string s1 = Source.Substring(0, 1).ToUpper();
        string s2 = Source.Substring(1, 1).ToLower();
        string s3 = Source.Substring(2, 1).ToUpper();
        string d1 = Destination.Substring(0, 1).ToUpper();
        string d2 = Destination.Substring(1, 1).ToLower();
        string d3 = Destination.Substring(2, 1).ToUpper();
        return s1+s2+s3+ "-" +d1+d2+d3;

    }
    public double FindTicketPrice()
        {
            if (ReservationClass.Equals("AC"))
            {
                return Distance * 3.5;
            } 
            else
            {
                return Distance * 2.0;
            }
        }
    }
}
