/// <reference path="../../ember-1.0.0-rc.1.js" />
/// <reference path="../app.js" />
/// <reference path="../models/contact.js" />

App.ContactsController = Em.ArrayController.extend( {
    error: '',
    sortProperties: ['contactId'],
    sortAscending: true,

    hasError: function () {
        var currentError = this.get( 'error' );
        return !( currentError === '' || currentError === null );
    }.property( 'error' ),

    addTodoList: function () {
        var transaction = App.store.transaction();
        var contact = transaction.createRecord( App.Contact, {
            firstName: '',
            middleName: '',
            lastName: '',
            nickname: '',
            twitter: '',
            facebook: '',
            website: '',
            notes: ''
        });
        transaction.commit();
    },
    count: function () {
        return this.get( 'filteredContent.length' );
    }.property( 'filteredContent.@each' ),
    searchWord: '',
    hasItems: function () {
        return this.get( 'count' ) > 0;
    }.property( 'count' ),
    isSearchOn: function () {
        return this.get( 'searchWord' ) != '';
    }.property( 'searchWord' ),
    cleanRecords: function() {
        return this.get( 'content' ).filter( function ( contact ) {
            return true != contact.get( 'isDirty' );
        } );
    }.property('content.@each'),
    filteredContent: function () {
        var word = this.get( 'searchWord' ).toLowerCase();

        if ( '' == word ) {
            return this.get( 'content' );
        } else {
            return this.get( 'content' ).filter( function ( contact ) {
                return (
                            (
                                ( contact.get( 'fullName' ).toLowerCase().indexOf( word ) != -1 ) ||
                                ( contact.get( 'nickname' ).toLowerCase().indexOf( word ) != -1 )
                            ) &&  ( contact.get( 'isDirty' ) == false )
                       );
            } );
        }
    }.property( 'searchWord', 'cleanRecords' )
} );

App.ContactsAddController = Em.ObjectController.extend( {

    saveContact: function () {
        this.get( 'target' ).send( 'save', this.get( 'content' ) );
    },
    cancel: function () {
        this.get( 'target' ).send( 'cancel', this.get( 'content' ) );
    }
});