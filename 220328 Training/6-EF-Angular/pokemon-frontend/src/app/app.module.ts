import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import { EdithKennedyTynesComponent } from './edith-kennedy-tynes/edith-kennedy-tynes.component';
import { VladimirShnyakinComponent } from './vladimir-shnyakin/vladimir-shnyakin.component';
import { BricesonRoyComponent } from './briceson-roy/briceson-roy.component';
import { DanielOszczapinskiComponent } from './daniel-oszczapinski/daniel-oszczapinski.component';
import { AboutusComponent } from './aboutus/aboutus.component';
import { NavbarComponent } from './navbar/navbar.component';


@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    EdithKennedyTynesComponent,
    VladimirShnyakinComponent,
    BricesonRoyComponent,
    DanielOszczapinskiComponent,
    AboutusComponent,
    NavbarComponent
  ],
  imports: [
    BrowserModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
