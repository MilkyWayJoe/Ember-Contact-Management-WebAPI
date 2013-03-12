/// <reference path="models/contact.js" />
window.App = Em.Application.create();

DS.WebAPIAdapter.map( 'App.Contact', {
    // Web API server is not handling reference update/delete, so use "load" instead of "always"
    todos: { embedded: 'load' } 
});

var adapter = DS.WebAPIAdapter.create({
    namespace: "api",
    bulkCommit: false,
    antiForgeryTokenSelector: "#antiForgeryToken"
});

var serializer = Ember.get(adapter, 'serializer');

serializer.configure( 'App.Contact', {
    sideloadAs: 'contacts',
    primaryKey: 'contactId'
} );

App.store = DS.Store.create({
    adapter: adapter,
    revision: 11
});
