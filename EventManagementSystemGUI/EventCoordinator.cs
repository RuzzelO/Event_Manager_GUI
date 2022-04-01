using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystemGUI
{
    public class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        RSVPManager rsvpMan;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents, int rsvID, int maxAtt)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            rsvpMan = new RSVPManager(rsvID, maxAtt);

        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            
            return custMan.addCustomer(fname, lname, phone);
        }

        public bool addRSVP(int custId, int eventId, Date rsvpDate)
        {
            if (custMan.customerExist(custId) == false || eventMan.eventExists(eventId) == false)
            {
                return false;
            }
            Customer c = custMan.getCustomer(custId);
            Event e = eventMan.getEvent(eventId);

            return rsvpMan.addRSVP(c, e, rsvpDate);
        }


        public string customerList()
        {
            return custMan.getCustomerList();
        }

        public string getCustomerInfoById(int id)
        {
            return custMan.getCustomerInfo(id);
        }
        public bool deleteCustomer(int id)
        {
            return custMan.deleteCustomer(id);
        }

        // Event related methods
        public bool addEvent(string name, string venue, Date eventDate, int maxAttendee)
        {
            if (checkVenue(venue, eventDate.day) == false)
            {
                return false;
            }
            return eventMan.addEvent(name, venue, eventDate, maxAttendee);
        }

        public string eventList()
        {
            return eventMan.getEventList();
        }

        public string getEventInfoById(int id)
        {
            return eventMan.getEventInfo(id);
        }

        public string rsvpList()
        {

            return rsvpMan.getRsvpList();
        }

        public bool checkValidMonth(int month)
        {

            if (month > 12)
            {
                Console.Write("\nThat is not a valid month\n");
                return false;
            }

            return true;
        }

        public bool deleteCheckCust(int cid)
        {
            rsvpMan.removeRSVP(cid);
            eventMan.deleteAtt(cid);
            return true;
        }

        public bool checkVenue(string venue, int day)
        {
            return eventMan.venueValidate(venue, day);
        }

        public bool deleteEvent(int eid)
        {
            rsvpMan.removeRSVPEId(eid);
            return eventMan.deleteEvent(eid);
        }

    }
}
