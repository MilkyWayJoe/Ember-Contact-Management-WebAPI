App.Router.map( function () {
    this.resource( 'contacts', { path: 'contacts' }, function () {
        this.route( 'add', { path: 'add' } );
    } );
    this.resource( 'contact', function () {
        this.route( 'edit', { path: ':contact_id/edit' } );
        this.route( 'details', { path: ':contact_id' } );
    } );
} );

App.IndexRoute = Em.Route.extend( {
    redirect: function () {
        this.transitionTo( 'contacts.index' );
    }
} );