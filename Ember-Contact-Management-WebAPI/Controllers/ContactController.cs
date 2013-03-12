using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ember_Contact_Management_WebAPI.Filters;
using Ember_Contact_Management_WebAPI.Models;

namespace Ember_Contact_Management_WebAPI.Controllers {
    [Authorize]
    public class ContactController : ApiController {
        private AppContext db = new AppContext();
        
        // GET api/contacts
        public IEnumerable<ContactDto> GetContacts() {
            var contacts = db.Contacts
                .Where(c => c.UserId == User.Identity.Name)
                .OrderByDescending( c => c.ContactId )
                .AsEnumerable()
                .Select( contact => new ContactDto( contact ) );
            return contacts;
        }

        // GET api/contacts/5
        public ContactDto GetContact( int id ) {
            var contact = db.Contacts.Find( id );
            if ( contact == null ) {
                throw new HttpResponseException( Request.CreateResponse( HttpStatusCode.NotFound ) );
            }
            if ( contact.UserId != User.Identity.Name ) {
                throw new HttpResponseException( Request.CreateResponse( HttpStatusCode.Unauthorized ) );
            }

            return new ContactDto( contact );
        }

        // PUT api/contacts/5
        [ValidateHttpAntiForgeryToken]
        public HttpResponseMessage PutContact( int id, ContactDto contactDto ) {
            if ( !ModelState.IsValid ) {
                return Request.CreateErrorResponse( HttpStatusCode.BadRequest, ModelState );
            }

            var model = contactDto.ToEntity();

            if ( db.Entry( model ).Entity.UserId != User.Identity.Name ) {
                return Request.CreateResponse( HttpStatusCode.Unauthorized );
            } else {
                model.UserId = User.Identity.Name;
            }

            db.Entry( model ).State = EntityState.Modified;

            try {
                db.SaveChanges();
            } catch ( DbUpdateConcurrencyException ) {
                return Request.CreateResponse( HttpStatusCode.InternalServerError );
            }

            return Request.CreateResponse( HttpStatusCode.OK );
        }

        // POST api/contacts
        [ValidateHttpAntiForgeryToken]
        public HttpResponseMessage PostContact( ContactDto contactDto ) {
            
            if ( !ModelState.IsValid ) {
                return Request.CreateErrorResponse( HttpStatusCode.BadRequest, ModelState );
            }



            var model = contactDto.ToEntity();
            model.UserId = User.Identity.Name;
            db.Contacts.Add( model );
            db.SaveChanges();
            contactDto.ContactId = model.ContactId;

            HttpResponseMessage response = Request.CreateResponse( HttpStatusCode.Created, contactDto );
            response.Headers.Location = new Uri( Url.Link( "DefaultApi", new { id = contactDto.ContactId } ) );
            return response;
        }

        // DELETE api/contacts/5
        [ValidateHttpAntiForgeryToken]
        public HttpResponseMessage DeleteContact( int id ) {
            var contact = db.Contacts.Find( id );
            if ( contact == null ) {
                return Request.CreateResponse( HttpStatusCode.NotFound );
            }


            if ( db.Entry( contact ).Entity.UserId != User.Identity.Name ) {
                return Request.CreateResponse( HttpStatusCode.Unauthorized );
            }

            var contactDto = new ContactDto(contact);
            db.Contacts.Remove( contact );

            try {
                db.SaveChanges();
            } catch ( DbUpdateConcurrencyException ) {
                return Request.CreateResponse( HttpStatusCode.InternalServerError );
            }

            return Request.CreateResponse( HttpStatusCode.OK, contactDto );
        }

        protected override void Dispose( bool disposing ) {
            db.Dispose();
            base.Dispose( disposing );
        }
    }
}