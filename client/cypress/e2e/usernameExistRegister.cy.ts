describe('usernameExistRegister.cy.ts', () => {
    it('shows an error message after register registrated user', () => {
      cy.visit('http://localhost:4200/home');
      cy.get('button').contains('REGISTER').click();
      cy.get('input[placeholder="Username"]').type('TestUsername20');
      cy.get('input[placeholder="Email"]').type('test3@gmail.com');
      cy.get('input[placeholder="First Name"]').type('Fname');
      cy.get('input[placeholder="Last name"]').type('Lname');
      cy.get('input[placeholder="Password"]').type('jakopako');
      cy.get('input[placeholder="Repeat password"]').type('jakopako');
      cy.get('button').contains('Register').click();
      cy.get('.mat-simple-snackbar').should('contain', 'Username already exist')
    });
  });
  