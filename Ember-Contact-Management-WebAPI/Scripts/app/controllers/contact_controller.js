/// <reference path="../../ember-1.0.0-rc.1.js" />
/// <reference path="../app.js" />
/// <reference path="../models/contact.js" />

App.ContactDetailsController = Em.ObjectController.extend( {
} );

App.ContactEditController = Em.ObjectController.extend( {
    deleteContact: function () {
        this.get( 'target' ).send( 'removeContact', this.get( 'content' ) );
    },
    saveContact: function () {
        this.get( 'target' ).send( 'save', this.get( 'content' ) );
    },
    cancelEdit: function () {
        this.get( 'target' ).send( 'cancel', this.get( 'content' ) );
    }
} );

App.ContactAddController = Em.ObjectController.extend( {
    saveContact: function () {
        this.get( 'target' ).send( 'save', this.get( 'content' ) );
    },
    cancel: function () {
        this.get( 'target' ).send( 'cancel', this.get( 'content' ) );
    }
} );