import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent, SpinnerType } from 'src/app/base/base.component';

@Component({
  selector: 'app-components',
  templateUrl: './components.component.html',
  styleUrls: ['./components.component.scss']
})
export class ComponentsComponent extends BaseComponent implements OnInit {
    constructor(spinner: NgxSpinnerService) {
      super(spinner);
      
    }
    ngOnInit(): void {
      this.showSpinner(SpinnerType.LineSpin);
    }

}
