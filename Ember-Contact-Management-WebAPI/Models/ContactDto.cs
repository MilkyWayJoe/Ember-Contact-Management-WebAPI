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