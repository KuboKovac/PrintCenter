describe('registerValidators.cy.ts', () => {
  it('should show validators in bad filling register', () => {
    cy.visit('https://printcenter-676dd.web.app/');
    cy.get('button').contains('REGISTER').click();
    //lenght 5 letters in username test
    cy.get('input[placeholder="Username"]').type('da');
    cy.get('input[placeholder="Email"]').click();
    cy.get('mat-error').should('contain', 'Username length must be at least 5');
    //Valid email
    cy.get('input[placeholder="Email"]').type('testemailgmail.com');
    cy.get('input[placeholder="First Name"]').click();
    cy.get('mat-error').should('contain', 'Enter valid email address');
    //Valid firstname / lastname
    cy.get('input[placeholder="Last name"]').type('J');
    cy.get('input[placeholder="Repeat password"]').click();
    // Valid password
    cy.get('input[placeholder="Password"]').type('12345');
    cy.get('input[placeholder="Repeat password"]').click();
    cy.get('mat-error').should('contain', 'Password length must be at least 6');
    cy.get('input[placeholder="Repeat password"]').type('1234');
    cy.get('span').contains('Register').click();
    cy.get('mat-error').should('contain', 'Passwords does not match');
  });
});
