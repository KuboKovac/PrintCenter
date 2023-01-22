describe('brands.cy.ts', () => {
  it('Cheks if after click on category shows right category', () => {
    cy.visit('http://localhost:4200/client/home');
    cy.wait(500);
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[3]/button/span[1]/mat-icon/div'
    ).click();
    
    //Creality

    let creality;
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[4]/div'
    )
      .invoke('text')
      .then((text) => {
        creality = text;
        cy.log(creality
);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[4]/div'
        ).click();
        cy.wait(500);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
        ).should('contain', creality);
        cy.url().should('include', '/Creality');
      });

    //Polymaker

    let polyMaker;
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[5]/div'
    )
      .invoke('text')
      .then((text) => {
        polyMaker = text;
        cy.log(polyMaker
);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[5]/div'
        ).click();
        cy.wait(500);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
        ).should('contain', polyMaker);
        cy.url().should('include', '/PolyMaker');
      });

    //Liqcreate

    let liqcreate;
    cy.xpath(
      '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[6]/div'
    )
      .invoke('text')
      .then((text) => {
        liqcreate = text;
        cy.log(liqcreate
);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[6]/div'
        ).click();
        cy.wait(500);
        cy.xpath(
          '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
        ).should('contain', liqcreate);
        cy.url().should('include', '/Liqcreate');
      });

      //Phrozen
  
      let phrozen;
      cy.xpath(
        '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[7]/div'
      )
        .invoke('text')
        .then((text) => {
            phrozen = text;
          cy.log(phrozen
  );
          cy.xpath(
            '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[7]/div'
          ).click();
          cy.wait(500);
          cy.xpath(
            '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
          ).should('contain', phrozen);
          cy.url().should('include', '/Phrozen');
        });
        
      //Anycubic
  
      let anycubic;
      cy.xpath(
        '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[8]/div'
      )
        .invoke('text')
        .then((text) => {
            anycubic = text;
          cy.log(anycubic
  );
          cy.xpath(
            '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav[1]/div/mat-tree/mat-tree-node[8]/div'
          ).click();
          cy.wait(500);
          cy.xpath(
            '/html/body/app-root/app-store-home/div/mat-sidenav-container/mat-sidenav-content/app-product-grid/div/div[1]/h1'
          ).should('contain', anycubic);
          cy.url().should('include', '/Anycubic');
        });
  });
});
