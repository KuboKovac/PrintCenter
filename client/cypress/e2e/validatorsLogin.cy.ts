import { contains } from 'cypress/types/jquery';

describe('validatorsLogin.cy.ts', () => {
  it('should show validators in bad filling login', () => {
    cy.visit('http://localhost:4200/home');
    cy.get('button').contains('LOGIN').click();
    //username required
    cy.get('button').contains('Login').click();
    cy.get('mat-error').should('contain', 'Username is required');
    //password required
    cy.get('input[placeholder ="Username"]').type('name');
    cy.get('input[placeholder ="Password"]').click();
    cy.get('input[placeholder ="Username"]').click();
    cy.get('mat-error').should('contain', 'Password is required');
  });
});
