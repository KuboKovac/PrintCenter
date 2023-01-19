import { contains } from "cypress/types/jquery";

describe('store.cy.ts', () => {
  it('Checks if h3 in store is same as h1 in detail', () => {
    let h3Text="";
    let h1Text;

    cy.visit('http://localhost:4200/home');
    cy.get('button[id="cyLogin"]').click();
    cy.get('input[id="cyUsername"]').type('TestUsername');
    cy.get('input[id="cyPassword"]').type('jakopako');
    cy.get('button').contains('Login').click();
    cy.get('.mat-simple-snackbar').should('contain', 'Logged in successfully');
    cy.get('p').contains('STORE').click();
    cy.get('button').contains('FDM Printers').click();
    cy.get('h3.prod-name-text').then(($h3) => {
        h3Text = $h3.text();
      });
    
    console.log(h3Text)
    cy.get('button').contains('Details').click();
    
    cy.get('h1.header-h1').should('contain', h3Text);

    cy.get('button').contains('LOGOUT').click();
  });
});
