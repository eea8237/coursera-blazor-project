using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private List<Event> events = new List<Event>();

        private static List<Event> testEvents = new List<Event>();
        public static List<Event> TestEvents {get => testEvents;}

        static EventService() 
        {
            testEvents = new List<Event>()
            {
                new Event {Name="event", Date="2/2/22", Location="someplace", Description="uhh"},
                new Event {Name="othr event", Date="3/3/33", Location="somewhere", Description="um"},
                new Event {Name="another event", Date="4/3/21", Location="idk", Description="oh"},
                new Event {Name="real", Date="8/3/26", Location="here", Description="doh"}
            };
        }

        public Event GetEvent(int id)
        {
            try 
            {
                return events[id];
            }
            catch
            {
                Console.WriteLine("invalid id");
                return null;
            }
        }

        public List<Event> GetEventsList() => new(events);

        public void RemoveEvent(int id)
        {
            try 
            {
                events.RemoveAt(id);
            }
            catch
            {
                Console.WriteLine("invalid id");
            }
        }

        public void AddEvent(Event newEvent) => events.Add(newEvent);

    }
}