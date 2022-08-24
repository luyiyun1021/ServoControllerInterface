import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { CoreModule } from './core/core.module';

import { AppRoutingModule } from './app-routing.module';
// NG Translate
import { TranslateModule, TranslateLoader } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { HomeComponent } from './components/home/home.component';
import { BottomComponent } from './components/bottom/bottom.component';
import { ImgComponent } from './components/img/img.component';
import { FormComponent } from './components/form/form.component';
import { SearchComponent } from './components/search/search.component';
import { TodolistComponent } from './components/todolist/todolist.component';

// ruiyiw
import { DataTablesModule } from 'angular-datatables';

import zh from '@angular/common/locales/zh';


// import{NZ_I18N} from 'ng-zorro-antd/i18n';
// import{zh_CN} from 'ng-zorro-antd/i18n';
// import{NzButtonModule} from 'ng-zorro-antd/button';
// import{NzIconModule} from 'ng-zorro-antd/icon';
// import{NzTypographyModule} from 'ng-zorro-antd/typography';

// import { NzGridModule } from 'ng-zorro-antd/grid';
// import { NzDividerModule } from 'ng-zorro-antd/divider';

// AoT requires an exported function for factories
const httpLoaderFactory = (http: HttpClient): TranslateHttpLoader =>  new TranslateHttpLoader(http, './assets/i18n/', '.json');


//引入并且配置服务
import { StorageService } from './services/storage.service';
import { registerLocaleData } from '@angular/common';
import { MachineComponent } from './components/machine/machine.component';

/* 引入自定义模块 */
/* import { MenuModule } from './module/externalref-menu/menu.module'; */

import { Menu } from 'electron';

registerLocaleData(zh);


@NgModule({
  declarations: [AppComponent,HeaderComponent,HomeComponent,BottomComponent, ImgComponent, FormComponent, SearchComponent, TodolistComponent, MachineComponent],
  imports: [

    BrowserModule,
    FormsModule,
    HttpClientModule,
    CoreModule, 
    AppRoutingModule,  
    DataTablesModule, // ruiyiw
   /*  MenuModule, */ /* HMI用 */
   
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: httpLoaderFactory,
        deps: [HttpClient]
      }
    }),

    // NzButtonModule,
    //  NzIconModule,
    //  NzTypographyModule,
    //  NzGridModule,
    //  NzDividerModule,
     
  ],
  providers: [StorageService],
  bootstrap: [AppComponent]
})
export class AppModule {}
