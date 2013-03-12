App.Contact = DS.Model.extend( {
    contactId: DS.attr('number'),
    firstName: DS.attr( 'string' ),
    middleName: DS.attr( 'string' ),
    lastName: DS.attr( 'string' ),
    nickname: DS.attr( 'string' ),
    pictureUrl: DS.attr('string'),
    twitter: DS.attr( 'string' ),
    facebook: DS.attr( 'string' ),
    notes: DS.attr( 'string' ),
    userId: DS.attr('string'),
    fullName: function () {
        return '%@ %@%@'.fmt(
			this.get( 'firstName' ),
			this.get( 'middleName' ) !== null ? '%@ '.fmt( this.get( 'middleName' ) ) : '',
			this.get( 'lastName' )
		);
    }.property( 'firstName', 'middleName', 'lastName' )

} );