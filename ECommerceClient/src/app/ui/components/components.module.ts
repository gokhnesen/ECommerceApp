import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BasketsComponent } from './baskets/baskets.component';
import { ProductsModule } from './products/products.module';
import { HomeModule } from './home/home.module';
import { BasketsModule } from './baskets/baskets.module';



@NgModule({
  declarations: [
    
  ],
  imports: [
    CommonModule,
    ProductsModule,
    HomeModule,
    BasketsModule
    
  ]
})
export class ComponentsModule { }
