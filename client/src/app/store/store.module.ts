import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StoreHomeComponent } from './store-home/store-home.component';
import { NavStoreComponent } from './nav-store/nav-store.component';



@NgModule({
  declarations: [
    StoreHomeComponent,
    NavStoreComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    StoreHomeComponent
  ]
})
export class StoreModule { }
