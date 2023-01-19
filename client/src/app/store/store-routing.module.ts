import {NgModule} from "@angular/core";
import {RouterModule} from "@angular/router";
import {StoreHomeComponent} from "./store-home/store-home.component";
import {ProductGridComponent} from "./product-grid/product-grid.component";
import {GridMenuComponent} from "./grid-menu/grid-menu.component";
import {BasketComponent} from "./basket/basket.component";
import {AdminComponent} from "./admin/admin.component";
import {ProductDetailComponent} from "./product-detail/product-detail.component";
import {OrderStepperComponent} from "./order-stepper/order-stepper.component";
import {AdminGuard} from "../auth/admin.guard";
import {OrderSuccessComponent} from "./order-success/order-success.component";

const routes = [
  {path: 'store', component: StoreHomeComponent, children:
    [
      {path: '', component: GridMenuComponent},
      {path: 'menu',component: GridMenuComponent},
      {path: 'grid',component: ProductGridComponent},
      {path: 'basket',component: BasketComponent},
      {path: 'basket/order', component: OrderStepperComponent},
      {path: 'basket/order-success', component: OrderSuccessComponent},
      {path: ':id', component: ProductGridComponent},
      {path: ':id/:detailId', component: ProductDetailComponent},
    ]
  }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StoreRoutingModule {
}
