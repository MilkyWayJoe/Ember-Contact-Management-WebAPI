using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ember_Contact_Management_WebAPI.Models {
    public class ContactDto {
        /// <summary>
        /// Data transfer object for <see cref="Contact"/>
        /// </summary>
        public ContactDto() { }

        public ContactDto( Contact contact ) {
            ContactId = contact.ContactId;
            FirstName = contact.FirstName;
            MiddleName = contact.MiddleName;
            LastName = contact.LastName;
            Nickname = contact.Nickname;
            PictureUrl = contact.PictureUrl;
            Twitter = contact.Twitter;
            Facebook = contact.Facebook;
            Website = Website;
            Notes = contact.Notes;
            UserId = contact.UserId;
        }

        [Key]
        public int ContactId { get; set; }
        [MaxLength(50)]
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

        public Contact ToEntity() {
            return new Contact {
                ContactId = ContactId,
                FirstName = FirstName,
                MiddleName = MiddleName,
                LastName = LastName,
                Nickname = Nickname,
                PictureUrl = PictureUrl,
                Twitter = Twitter,
                Facebook = Facebook,
                Website = Website,
                Notes = Notes,
                UserId = UserId
            };
        }
    }
}