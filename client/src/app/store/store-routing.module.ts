import {NgModule} from "@angular/core";
import {RouterModule} from "@angular/router";
import {StoreHomeComponent} from "./store-home/store-home.component";
import {ProductGridComponent} from "./product-grid/product-grid.component";
import {GridMenuComponent} from "./grid-menu/grid-menu.component";
import {BasketComponent} from "./basket/basket.component";
import {AdminComponent} from "./admin/admin.component";

const routes = [
  {path: 'store', component: StoreHomeComponent, children:
    [
      {path: '', component: GridMenuComponent},
      {path: 'menu',component: GridMenuComponent},
      {path: 'grid',component: ProductGridComponent},
      {path: 'basket',component: BasketComponent},
      {path: 'administration', component: AdminComponent},
      {path: ':id', component: ProductGridComponent},
    ]
  }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StoreRoutingModule {
}
