import {NgModule} from "@angular/core";
import {RouterModule} from "@angular/router";
import {StoreHomeComponent} from "./store-home/store-home.component";
import {ProductGridComponent} from "./product-grid/product-grid.component";
import {GridMenuComponent} from "./grid-menu/grid-menu.component";
import {BasketComponent} from "./basket/basket.component";

const routes = [
  {path: '', component: StoreHomeComponent, children:
    [
      {path: '', component: ProductGridComponent},
      {path: 'store/menu',component: GridMenuComponent},
      {path: 'store/basket',component: BasketComponent}
    ]
  }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StoreRoutingModule {
}
