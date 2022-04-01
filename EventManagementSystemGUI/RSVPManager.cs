using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystemGUI
{
    class RSVPManager : RSVP
    {
        private RSVP[] rsvpList;
        private int numberOfRSVPList;
        private static int currentRsvpID;
        private static int maxAtten;
       
       

        
        public RSVPManager(int rsvID, int maxAtt)
        {
            currentRsvpID = rsvID;
            numberOfRSVPList = 0;
            maxAtten = maxAtt;
            rsvpList = new RSVP[maxAtt];
        }

        public bool addRSVP(Customer c, Event e, Date rsvpDate)
        {
            if (e.addAttendee(c) == false)
            {
                return false;
            }
            RSVP z = new RSVP(currentRsvpID, c, e, rsvpDate);
            rsvpList[numberOfRSVPList] = z;
            numberOfRSVPList++;
            currentRsvpID++;
            c.addBooking();
            c.getNumBookings();
            return true;
        }

        public int findRSVP(int eid)
        {
            for (int i = 0; i < maxAtten; i++)
            {
                if (rsvpList[i].getRSVPEventID() == eid)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool removeRSVP(int cid)
        {
            for(int x = 0; x < numberOfRSVPList; x++)
            {
                if(cid == rsvpList[x].getRSVPCustomerID())
                {
                    rsvpList[x] = rsvpList[numberOfRSVPList-1];
                    numberOfRSVPList--;
                    return true;
                }
            }

            return false;
        }

        public bool removeRSVPEId(int eid)
        {
            int loc = findRSVP(eid);
            if (loc == -1) { return false; }
          
            for(int i = 0; i < numberOfRSVPList; i++)
            {
                rsvpList[loc].deleteBook();
                loc++;
            }

            rsvpList[loc] = rsvpList[numberOfRSVPList - 1];
          
            return true;
            
        }


        public string getRsvpList()
        {
            string s = "RSVP List:";
            for (int x = 0; x < numberOfRSVPList; x++)
            {
                s = s + "\n" + rsvpList[x].getRSVPID() + " \t " + rsvpList[x].getRSVPCustomerID() + " \t " + rsvpList[x].getRSVPCustomerName() + " \t " + rsvpList[x].getRSVPEventID() + " \t " + rsvpList[x].getRSVPEventName();
            }
            return s;
        }


    }
}
