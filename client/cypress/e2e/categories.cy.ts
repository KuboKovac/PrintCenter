import { ɵisDefaultChangeDetectionStrategy } from '@angular/core';
import { should } from 'chai';
import * as cypress from 'cypress';

describe('categories.cy.ts', () => {
  it('Cheks if after click on category shows right category', () => {
    cy.visit('http://localhost:4200/client/home');
    cy.wait(500);
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[2]/button/span[1]/mat-icon/div'
    ).click();

    //Fdm priters

    let fdmprintersGet;
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[3]/div'
    )
      .invoke('text')
      .then((text) => {
        fdmprintersGet = text;
        cy.log(fdmprintersGet);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[3]/div'
        ).click();
        cy.wait(500);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
        ).should('contain', fdmprintersGet);
        cy.url().should('include', '/FDM%20Printers');
      });

    //Resin printers

    let resinPrintersGet;
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[4]/div'
    )
      .invoke('text')
      .then((text) => {
        resinPrintersGet = text;
        cy.log(resinPrintersGet);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[4]/div'
        ).click();
        cy.wait(500);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
        ).should('contain', resinPrintersGet);
        cy.url().should('include', '/Resin%20Printers');
      });

    //Filaments

    let filamentsGet;
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[5]/div'
    )
      .invoke('text')
      .then((text) => {
        filamentsGet = text;
        cy.log(filamentsGet);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[5]/div'
        ).click();
        cy.wait(500);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
        ).should('contain', filamentsGet);
        cy.url().should('include', '/Filaments');
      });

    //Resins

    let resinsGet;
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[6]/div'
    )
      .invoke('text')
      .then((text) => {
        resinsGet = text;
        cy.log(resinsGet);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[6]/div'
        ).click();
        cy.wait(500);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
        ).should('contain', resinsGet);
        cy.url().should('include', '/Resins');
      });

    //Parts

    let partsGet;
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[7]/div'
    )
      .invoke('text')
      .then((text) => {
        partsGet = text;
        cy.log(partsGet);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[7]/div'
        ).click();
        cy.wait(500);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
        ).should('contain', partsGet);
        cy.url().should('include', '/Parts');
      });
  });
});
