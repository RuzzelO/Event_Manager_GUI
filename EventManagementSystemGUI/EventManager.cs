using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystemGUI
{
    public class EventManager
    {
        private static int currentEventId;
        private int maxEvents;
        private int numEvents;
        private Event[] eventList;




        public EventManager()
        {


        }
        public EventManager(int idSeedEvent, int max)
        {
            currentEventId = idSeedEvent;
            maxEvents = max;
            numEvents = 0;
            eventList = new Event[maxEvents];

        }

        public bool addEvent(string name, string venue, Date eventDate, int maxAttendees)
        {
            if (numEvents >= maxEvents) { return false; }
            Event e = new Event(currentEventId, name, venue, eventDate, maxAttendees);
            eventList[numEvents] = e;
            numEvents++;
            currentEventId++;
            return true;
        }

        private int findEvent(int eid)
        {
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getEventId() == eid)
                    return x;
            }
            return -1;
        }

        public bool venueValidate(string venue, int day)
        {
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getVenue() == venue && eventList[x].getEventDate() == day)
                    return false;
            }
            return true;
        }

        public bool deleteAtt(int cid)
        {
            for(int x = 0; x < numEvents; x++)
            {
                if(eventList[x].removeAttendee(cid))
                {
                    return true;
                }    
            }
            return false;
        }

        public bool eventExists(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            return true;
        }

        public Event getEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return null; }
            return eventList[loc];
        }


         
        public bool deleteEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            eventList[loc] = eventList[numEvents - 1];
            numEvents--;
            return true;
        }
        public string getEventInfo(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return "There is no event with id " + eid + "."; }
            return eventList[loc].ToString();
        }



        public string getEventList()
        {
            string s = "";
            for (int x = 0; x < numEvents; x++)
            {
                s = s + eventList[x].getEventId() + " \t " + eventList[x].getEventName() + " \t " + eventList[x].getVenue() + " \t " + eventList[x].getNumAttendees()+"\n";
            }
            return s;
        }


    }
}
