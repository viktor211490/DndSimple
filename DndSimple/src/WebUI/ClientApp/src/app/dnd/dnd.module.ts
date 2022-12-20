import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {DndRoutingModule} from "./dnd-routing.module";
import {DndComponent} from "./dnd.component";
import { TestComponent } from './test/test.component';
import { NestComponent } from './nest/nest.component';



@NgModule({
  declarations: [
    TestComponent,
    NestComponent
  ],
  imports: [
    CommonModule,
    DndRoutingModule,
  ]
})
export class DndModule { }
