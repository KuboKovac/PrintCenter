describe('Login.cy.ts', () => {
  it('shows an error message when login fails', () => {
    cy.visit('http://localhost:4200/home');
    cy.get('button[id="cyLogin"]').click()

    cy.get('input[id="cyUsername"]').click()


  })
})