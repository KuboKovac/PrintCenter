import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {HomeComponent} from "./core/home/home.component";
import {AccountDetailComponent} from "./core/account-detail/account-detail.component";
import {P404Component} from "./core/p404/p404.component";
import {AboutUsComponent} from "./core/about-us/about-us.component";
import {AdminComponent} from "./store/admin/admin.component";
import {AdminGuard} from "./auth/admin.guard";

const routes: Routes = [
  {path: '', redirectTo: 'home',pathMatch:'full'},
  {path: 'home', component: HomeComponent},
  {path: 'account-detail', component: AccountDetailComponent},
  {path: 'about', component: AboutUsComponent},
  {path: 'administration', component: AdminComponent, canActivate: [AdminGuard]},
  {path: 'store', loadChildren: () => import('src/app/store/store.module').then(m => m.StoreModule), pathMatch:'full'},
  {path: '**', component: P404Component},
];

@NgModule({
  imports: [RouterModule.forRoot(routes,/*{enableTracing: true}*/)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
