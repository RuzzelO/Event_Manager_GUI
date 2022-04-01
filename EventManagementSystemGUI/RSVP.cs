using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystemGUI
{
    class RSVP
    {
        
        private int rsvpID;
        private Date rsvpDate;
        private Customer c;
        private Event e;
        public string dateCreated;
        public RSVP()
        {

        }
        public RSVP(int rsvpID, Customer c, Event e, Date rsvpDate)
        {
            this.rsvpID = rsvpID;
            this.c = c;
            this.e = e;
            this.rsvpDate = rsvpDate;
            dateCreated = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }

        public int getRSVPID() { return rsvpID; }
        public int getRSVPCustomerID() { return c.getId(); }
        public string getRSVPCustomerName() { return c.getFirstName(); }
        public int getRSVPEventID()
        {
            return e.getEventId();
        }

        public int deleteBook()
        {
            return c.removeBooking();
        }
        public string getRSVPEventName() { return e.getEventName(); }


        public override string ToString()
        {
            string s = "RSVP ID: " + rsvpID;
            s = s + "\nDate:" + rsvpDate;
            s = s + "\nCustomer: " + getRSVPCustomerID() + "  " + getRSVPCustomerName();
            s = s + "\nEvent: " + getRSVPEventID() + "  " + getRSVPEventName();
            return s;
        }


    }
}
