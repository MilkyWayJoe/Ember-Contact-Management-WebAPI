/// <reference path="../../ember-1.0.0-rc.1.js" />
/// <reference path="../app.js" />
/// <reference path="../models/contact.js" />

App.ContactsRoute = Em.Route.extend( {
    model: function() {
        return App.Contact.find();
    },
    setupController: function(controller, model) {
        controller.set( 'content', App.Contact.find() );
    },
    renderTemplate: function() {

        var controller = this.controllerFor('contacts');
        var models = this.get('currentModel');
        controller.set('content', models);

        this.render('contacts/index', {
            into: 'application', 
            outlet: 'content',
            controller: controller
        });

        this.render('contacts/sidebar', {
            into: 'application', 
            outlet: 'sidebar'
        });
    },
    events: {
        deleteContact: function(record) {
            record.deleteRecord();
            record.store.commit();
        }
    }
} );