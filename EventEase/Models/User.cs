using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventEase.Models
{
    public class User
    {
        
        [Required(ErrorMessage = "Must enter a name.")]
        public string Name {get; set;}

        [EmailAddress(ErrorMessage = "Email address must be in a valid format.")]
        public string Email {get; set;}

        [Phone(ErrorMessage = "Phone number must be in a valid format.")]
        public string PhoneNumber {get; set;}

        public override string ToString()
        {
            return $"User:\n" + 
                $"Name: {Name}\n" +
                $"Email: {Email}\n" +
                $"Phone Number: {PhoneNumber}";
        }

    }
}