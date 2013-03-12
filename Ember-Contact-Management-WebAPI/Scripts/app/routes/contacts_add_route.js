App.ContactsAddRoute = Em.Route.extend({
    model: function() {
        return App.Contact.createRecord();
    },
    renderTemplate: function() {

        this.render('contacts/add', {
            into: 'application', 
            outlet: 'content'
        });

        this.render('contacts/add/sidebar', {
            into: 'application', 
            outlet: 'sidebar'
        });
    },
    events: {
        save: function(record) {
            record.get('transaction').commit();
            this.transitionTo('index');
        }, 
        cancel: function(record) {
            record.get('transaction').rollback();
            this.transitionTo('index')
        }
    }
});