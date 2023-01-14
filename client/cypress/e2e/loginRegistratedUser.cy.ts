describe('wrongLogin.cy.ts', () => {
  it('After registration login registrated user', () => {
    cy.visit('http://localhost:4200/home');
    cy.get('button[id="cyLogin"]').click()
    cy.get('input[id="cyUsername"]').type('TestUsername')
    cy.get('input[id="cyPassword"]').type('jakopako')
    cy.get('button').contains('Login').click()
    cy.get('.mat-simple-snackbar').should('contain', 'Logged in successfully')
    cy.get('button[id="cyLogout"]').click()


    

   


  })
})