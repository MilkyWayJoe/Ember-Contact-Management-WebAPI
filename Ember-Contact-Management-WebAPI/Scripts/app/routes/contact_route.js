App.ContactDetailsRoute = Em.Route.extend( {
    model: function ( params ) {
        return App.Contact.find( params.contact_id );
    },
    renderTemplate: function () {
        this.render( 'contact/view', {
            into: 'application',
            outlet: 'content'
        } );

        this.render( 'contact/sidebar', {
            into: 'application',
            outlet: 'sidebar'
        } );
    }
} );