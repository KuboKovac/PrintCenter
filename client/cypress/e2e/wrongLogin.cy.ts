//test for Wrong username and password

describe('wrongLogin.cy.ts', () => {
  it('shows an error message when login fails', () => {
    cy.visit('http://localhost:4200/home');
    cy.get('button[id="cyLogin"]').click()
    cy.get('input[id="cyUsername"]').type('FakeUsername')
    cy.get('input[id="cyPassword"]').type('FakePassword')
    cy.get('button[id="cyLoginForm"]').click()
    cy.get('.mat-simple-snackbar').should('contain', 'Username or password is wrong')
    
  })
})