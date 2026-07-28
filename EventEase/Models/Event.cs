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
        public List<User> RegisteredUsers {get; set;} = new List<User>();

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
            try
            {
                for (int i = 0; i < RegisteredUsers.Count; i++)
                {
                    if (i < RegisteredUsers.Count-1) registeredUsers += $"{RegisteredUsers[i].Name}, ";
                    else registeredUsers += RegisteredUsers[i].Name;
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