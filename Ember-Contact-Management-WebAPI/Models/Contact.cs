using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ember_Contact_Management_WebAPI.Models {
    
    public class Contact {

        public int ContactId { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string PictureUrl { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Website { get; set; }
        public string Notes { get; set; }

        public string UserId { get; set; }
    
    }

}