using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EventEase.Models
{
    public class Event
    {
        public int Id {get; set;}
        
        [Required(ErrorMessage = "Must enter an event name.")]
        public string Name {get; set;}
        public string Date {get; set;}
        public string Location {get; set;}
        [StringLength(300, ErrorMessage = "Maximum description length is 300 characters.")]
        public string Description {get; set;}

        public override string ToString()
        {
            return $"Event:\n" + 
                $"Name: {Name}\n" +
                $"Date: {Date}\n" +
                $"Location: {Location}\n" +
                $"Description: {Description}";
        }
    }
}