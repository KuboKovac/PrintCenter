import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ForumHomeComponent } from './forum-home/forum-home.component';



@NgModule({
  declarations: [
    ForumHomeComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    ForumHomeComponent
  ]
})
export class ForumModule { }
