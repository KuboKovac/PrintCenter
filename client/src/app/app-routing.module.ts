import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {HomeComponent} from "./core/home/home.component";
import {StoreHomeComponent} from "./store/store-home/store-home.component";
import {ForumHomeComponent} from "./forum/forum-home/forum-home.component";
import {ModelsHomeComponent} from "./models/models-home/models-home.component";

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'store', component: StoreHomeComponent},
  {path: 'forum', component: ForumHomeComponent},
  {path: 'models', component: ModelsHomeComponent},
  {path: '**', component: HomeComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes,/*{enableTracing: true}*/)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
