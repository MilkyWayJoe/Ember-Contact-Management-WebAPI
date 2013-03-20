using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ember_Contact_Management_WebAPI.Models {
    
    public class Contact {

        [Key]
        public int ContactId { get; set; }
        [MaxLength( 50 )]
        public string FirstName { get; set; }
        [MaxLength( 50 )]
        public string MiddleName { get; set; }
        [MaxLength( 50 )]
        public string LastName { get; set; }
        [MaxLength( 50 )]
        public string Nickname { get; set; }
        [MaxLength( 255 )]
        public string PictureUrl { get; set; }
        [MaxLength( 50 )]
        public string Twitter { get; set; }
        [MaxLength( 50 )]
        public string Facebook { get; set; }
        [MaxLength( 100 )]
        public string Website { get; set; }
        [MaxLength( 500 )]
        public string Notes { get; set; }

        public string UserId { get; set; }
    
    }

}