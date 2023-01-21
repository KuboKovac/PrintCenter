import { contains } from 'cypress/types/jquery';

describe('store.cy.ts', () => {
  it('Checks if h3 in store is same as h1 in detail', () => {
    let h3Text;
    let h1Text;

    cy.visit('http://localhost:4200/home');
    cy.get('button[id="cyLogin"]').click();
    cy.get('input[id="cyUsername"]').type('TestUsername');
    cy.get('input[id="cyPassword"]').type('jakopako');
    cy.get('button').contains('Login').click();
    cy.get('.mat-simple-snackbar').should('contain', 'Logged in successfully');
    cy.get('p').contains('STORE').click();
    cy.url().should('include', '/client/store');
    cy.get('button').contains('Resin Printers').click();
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[3]/div/div/div/div[1]/h3'
    )
      .invoke('text')
      .then((text) => {
        h3Text = text;
        cy.log(h3Text);

        cy.get('button').contains('Details').click();

        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-detail/div/div[1]/div[2]/h1'
        ).should('contain', h3Text);
      });

    cy.get('button').contains('LOGOUT').click();
  });
});
