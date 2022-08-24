import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductRoutingModule } from './product-routing.module';
import { ProductComponent } from './product.component';
import { PlistComponent } from './components/plist/plist.component';
import { PinfoComponent } from './components/pinfo/pinfo.component';


@NgModule({
  declarations: [
    ProductComponent,
    PlistComponent,
    PinfoComponent
  ],
  imports: [
    CommonModule,
    ProductRoutingModule
  ]
})
export class ProductModule { }
