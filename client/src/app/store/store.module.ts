import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {StoreHomeComponent} from './store-home/store-home.component';
import {MatSidenavModule} from "@angular/material/sidenav";
import {MatIconModule} from "@angular/material/icon";
import {MatTreeModule} from "@angular/material/tree";
import {MatInputModule} from "@angular/material/input";
import {MatButtonModule} from "@angular/material/button";
import { ProductGridComponent } from './product-grid/product-grid.component';
import { GridMenuComponent } from './grid-menu/grid-menu.component';
import {RouterOutlet} from "@angular/router";
import {StoreRoutingModule} from "./store-routing.module";
import { BasketComponent } from './basket/basket.component';
import {HttpClientModule} from "@angular/common/http";
import {MatPaginatorModule} from "@angular/material/paginator";


@NgModule({
  declarations: [
    StoreHomeComponent,
    ProductGridComponent,
    GridMenuComponent,
    BasketComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,

    MatSidenavModule,
    MatIconModule,
    MatTreeModule,
    MatInputModule,
    MatButtonModule,
    MatPaginatorModule,

    StoreRoutingModule,
    RouterOutlet
  ],
  exports: [
    StoreHomeComponent
  ]
})
export class StoreModule {
}
