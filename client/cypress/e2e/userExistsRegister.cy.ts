describe('wrongLogin.cy.ts', () => {
  it('shows an error message when login fails', () => {
    cy.visit('http://localhost:4200/home');
    // register user
    function getRandomNumber() {
      return Math.floor(Math.random() * 1000000000);
    }
    let usernameWithNum=getRandomNumber()+'TestUsername'.toString()
    let emailWithNum='test'+getRandomNumber()+'@gmail.com'.toString
    cy.get('button').contains('REGISTER').click();
    cy.get('input[placeholder="Username"]').type(usernameWithNum);
    cy.get('input[placeholder="Email"]').type('test'+getRandomNumber()+'@gmail.com');
    cy.get('input[placeholder="First Name"]').type('Fname');
    cy.get('input[placeholder="Last name"]').type('Lname');
    cy.get('input[placeholder="Password"]').type('jakopako');
    cy.get('input[placeholder="Repeat password"]').type('jakopako');
    cy.get('button').contains('Register').click();
    cy.get('.mat-simple-snackbar').should(
      'contain',
      'User successfully registered!'
    );

    //trying to register with same Username

    cy.get('button').contains('REGISTER').click();
    cy.get('input[placeholder="Username"]').type(usernameWithNum);
    cy.get('input[placeholder="Email"]').type('test'+getRandomNumber()+'@gmail.com');
    cy.get('input[placeholder="First Name"]').type('Fname');
    cy.get('input[placeholder="Last name"]').type('Lname');
    cy.get('input[placeholder="Password"]').type('jakopako');
    cy.get('input[placeholder="Repeat password"]').type('jakopako');
    cy.get('button').contains('Register').click();
    cy.get('.mat-simple-snackbar').should('contain', 'Username already exist');
  });
});
