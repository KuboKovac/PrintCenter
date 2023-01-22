describe('darkMode.cy.ts', () => {
  it('turn on darkmode', () => {
    cy.visit('http://localhost:4200/client');
    cy.get('mat-slide-toggle').click();
    cy.get('mat-slide-toggle').click();
    cy.get('h1').should('have.css', 'color', 'rgb(255, 255, 255)');
  });
});
