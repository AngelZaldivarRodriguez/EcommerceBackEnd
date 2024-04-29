import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { NavBarComponent } from './core/nav-bar/nav-bar.component';
import { ShopComponent } from './shop/shop.component';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss',
    imports: [
      CommonModule, 
      RouterOutlet, 
      HttpClientModule,
      NavBarComponent,
      ShopComponent
    ]
})
export class AppComponent implements OnInit {
  title = 'Eccomerce';

  constructor() {}
  
  ngOnInit(): void {
    
  }
}
