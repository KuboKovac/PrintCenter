import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModelsHomeComponent } from './models-home/models-home.component';



@NgModule({
  declarations: [
    ModelsHomeComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    ModelsHomeComponent
  ]
})
export class ModelsModule { }
