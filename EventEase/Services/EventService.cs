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