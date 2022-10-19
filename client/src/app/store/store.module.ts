import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StoreHomeComponent } from './store-home/store-home.component';



@NgModule({
  declarations: [
    StoreHomeComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    StoreHomeComponent
  ]
})
export class StoreModule { }
