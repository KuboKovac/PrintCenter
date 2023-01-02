import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {HomeComponent} from "./core/home/home.component";
import {AccountDetailComponent} from "./core/account-detail/account-detail.component";
import {P404Component} from "./core/p404/p404.component";

const routes: Routes = [
  {path: '', redirectTo: 'home',pathMatch:'full'},
  {path: 'home', component: HomeComponent},
  {path: 'account-detail', component: AccountDetailComponent},
  {path: 'store', loadChildren: () => import('src/app/store/store.module').then(m => m.StoreModule), pathMatch:'full'},
  {path: '**', component: P404Component},
];

@NgModule({
  imports: [RouterModule.forRoot(routes,/*{enableTracing: true}*/)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
