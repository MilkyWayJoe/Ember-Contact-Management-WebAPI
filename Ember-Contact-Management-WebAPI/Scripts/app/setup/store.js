var adapter = DS.WebAPIAdapter.create( {
    namespace: "api",
    bulkCommit: false,
    antiForgeryTokenSelector: "#antiForgeryToken"
} );

var serializer = Ember.get( adapter, 'serializer' );

serializer.configure( 'App.Contact', {
    sideloadAs: 'contacts',
    primaryKey: 'contactId'
} );

App.store = DS.Store.create( {
    adapter: adapter,
    revision: 12
} );
