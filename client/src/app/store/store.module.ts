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


@NgModule({
  declarations: [
    StoreHomeComponent,
    ProductGridComponent,
    GridMenuComponent,
    BasketComponent
  ],
  imports: [
    CommonModule,

    MatSidenavModule,
    MatIconModule,
    MatTreeModule,
    MatInputModule,
    MatButtonModule,

    StoreRoutingModule,
    RouterOutlet
  ],
  exports: [
    StoreHomeComponent
  ]
})
export class StoreModule {
}
