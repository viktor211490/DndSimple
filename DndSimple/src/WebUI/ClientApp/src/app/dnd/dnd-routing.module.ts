import {NgModule} from '@angular/core';
import {RouterModule, Routes} from "@angular/router";
import {TestComponent} from "./test/test.component";
import {NestComponent} from "./nest/nest.component";

export const routes: Routes = [

  {
    path: '',
    component: TestComponent,
    pathMatch: 'full'
  },
  {
    path: 'nest',
    component: NestComponent,
  },
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class DndRoutingModule {
}
