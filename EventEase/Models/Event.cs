using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventEase.Models
{
    public class Event
    {
        public int Id {get; set;}
        
        [Required(ErrorMessage = "Must enter an event name.")]
        public string Name {get; set;}
        public string? Date {get; set;}
        public string? Location {get; set;}
        [StringLength(300, ErrorMessage = "Maximum description length is 300 characters.")]
        public string? Description {get; set;}

        // bool is false if user hasn't attended event, true if they have
        public Dictionary<User, bool> RegisteredUsers {get; set;} = new Dictionary<User, bool>();

        public override string ToString()
        {
            
            return $"Event:\n" + 
                $"Name: {Name}\n" +
                $"Date: {Date}\n" +
                $"Location: {Location}\n" +
                $"Description: {Description}\n" +
                $"Registered: {GetRegisteredString()}";;
        }

        public string GetRegisteredString()
        {
            var registeredUsers = "";
            List<User> registeredKeys = new List<User>(RegisteredUsers.Keys);
            try
            {
                for (int i = 0; i < registeredKeys.Count; i++)
                {
                    if (i < RegisteredUsers.Count-1) registeredUsers += $"{registeredKeys[i].Name}, ";
                    else registeredUsers += registeredKeys[i].Name;
                }    
            }
            catch
            {
                Console.WriteLine("Error: no registered users");
                Console.WriteLine(RegisteredUsers);
            }
            
            return registeredUsers;
        }
    }
}