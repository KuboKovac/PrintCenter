describe('loginRegistratedUser.cy.ty', () => {
  it('After registration login registrated user', () => {
    cy.visit('http://localhost:4200/home');
    cy.get('button[id="cyLogin"]').click();
    cy.get('input[id="cyUsername"]').type('Dekel');
    cy.get('input[id="cyPassword"]').type('heslo');
    cy.get('button').contains('Login').click();
    cy.get('.mat-simple-snackbar').should('contain', 'Logged in successfully');
    cy.get('button').contains('LOGOUT').click();
  });
});
