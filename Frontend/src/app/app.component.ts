import { Component } from '@angular/core';
import { ElectronService } from './core/services';
import { TranslateService } from '@ngx-translate/core';
import { APP_CONFIG } from '../environments/environment';
import { Router} from '@angular/router';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  constructor(
    private electronService: ElectronService,
    private translate: TranslateService,
    private router:Router
  ) {
    this.translate.setDefaultLang('en');
    console.log('APP_CONFIG', APP_CONFIG);

    if (electronService.isElectron) {
      console.log(process.env);
      console.log('Run in electron');
      console.log('Electron ipcRenderer', this.electronService.ipcRenderer);
      console.log('NodeJS childProcess', this.electronService.childProcess);
    } else {
      console.log('Run in browser');
    }
  }

  BtOne_Click(){
    
    //alert("按钮1事件");
    //this.router.navigate(['/news']);

  }

  BtTwo_Click(){
    
    //alert("按钮2事件");
   // this.router.navigate(['/search']);

  }

  BtThree_Click(){
    
    //alert("按钮3事件");
    // this.router.navigate(['/regionmac']);
    // ruiyiw
    this.router.navigate(['/message']);


  }

  BtMenu_Click(){
   // alert("按钮Menu事件");

   this.router.navigate(['/menu']);


  }
}
