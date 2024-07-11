// src/app/app.module.ts

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms'; // FormsModule'ü ekleyin

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { HakkimizdaComponent } from './hakkımızda/hakkimizda/hakkimizda.component';
import { SliderComponent } from './slider/slider/slider.component';
import { HaberlerComponent } from './haberler/haberler/haberler.component';
import { EtkinliklerComponent } from './etkinlikler/etkinlikler/etkinlikler.component';
import { FirmalarComponent } from './firmalar/firmalar/firmalar.component';
import { LoginComponent } from './login/login/login.component';
import { AnamenuComponent } from './anamenu/anamenu/anamenu.component';
import { AdminComponent } from './admin/admin/admin.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    HakkimizdaComponent,
    SliderComponent,
    HaberlerComponent,
    EtkinliklerComponent,
    FirmalarComponent,
    LoginComponent,
    AnamenuComponent,
    AdminComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule // FormsModule'ü imports listesine ekleyin
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
