import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ArticleRoutingModule } from './article-routing.module';
import { ArticleComponent } from './article.component';
import { ArticlelistComponent } from './components/articlelist/articlelist.component';
import { InfoComponent } from './components/info/info.component';
import { PlistComponent } from './product/plist/plist.component';
import { PinfoComponent } from './product/pinfo/pinfo.component';


@NgModule({
  declarations: [
    ArticleComponent,
    ArticlelistComponent,
    InfoComponent,
    PlistComponent,
    PinfoComponent
  ],
  imports: [
    CommonModule,
    ArticleRoutingModule
  ]
})
export class ArticleModule { }
