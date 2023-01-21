describe('register.cy.ts', () => {
  it('register new user', () => {
    cy.visit('http://localhost:4200/home');
    cy.get('button').contains('REGISTER').click();
    function getRandomNumber() {
      return Math.floor(Math.random() * 1000000000);
    }
    
    cy.get('input[placeholder="Username"]').type(
      'TestUsername0');

    cy.get('input[placeholder="Email"]').type('test0@gmail.com');
    cy.get('input[placeholder="First Name"]').type('Fname');
    cy.get('input[placeholder="Last name"]').type('Lname');
    cy.get('input[placeholder="Password"]').type('jakopako');
    cy.get('input[placeholder="Repeat password"]').type('jakopako');
    cy.get('button').contains('Register').click();
    cy.get('.mat-simple-snackbar')

      if (cy.get('.mat-simple-snackbar').contains('Username already exist')) {
        //clear form
        cy.get('input[placeholder="Username"]').clear();
        cy.get('input[placeholder="Email"]').clear();
        cy.get('input[placeholder="First Name"]').clear();
        cy.get('input[placeholder="Last name"]').clear();
        cy.get('input[placeholder="Password"]').clear();
        cy.get('input[placeholder="Repeat password"]').clear();
        cy.get('input[placeholder="Username"]').type(
          'TestUsername' + getRandomNumber().toString()
        );
        cy.get('input[placeholder="Email"]').type('test'+getRandomNumber().toString()+'@gmail.com');
        cy.get('input[placeholder="First Name"]').type('Fname');
        cy.get('input[placeholder="Last name"]').type('Lname');
        cy.get('input[placeholder="Password"]').type('jakopako');
        cy.get('input[placeholder="Repeat password"]').type('jakopako');
        cy.get('button').contains('Register').click();
        cy.get('.mat-simple-snackbar').should(
          'contain',
          'User successfully registered!'
        );
      }
    });
  });
