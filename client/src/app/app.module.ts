import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import {NavComponent} from './core/nav/nav.component';
import {FooterComponent} from './core/footer/footer.component';
import {NoopAnimationsModule} from '@angular/platform-browser/animations';
import {HeaderComponent} from './core/header/header.component';
import {MatSlideToggleModule} from "@angular/material/slide-toggle";
import {AuthModule} from "./auth/auth.module";
import {StoreModule} from "./store/store.module";
import {MatDialogModule} from "@angular/material/dialog";
import {HomeComponent} from './core/home/home.component';
import {MatToolbarModule} from "@angular/material/toolbar";
import {MatIconModule} from "@angular/material/icon";
import {MatButtonModule} from "@angular/material/button";
import { AccountDetailComponent } from './core/account-detail/account-detail.component';
import { P404Component } from './core/p404/p404.component';
import { AboutUsComponent } from './core/about-us/about-us.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    FooterComponent,
    HeaderComponent,
    HomeComponent,
    AccountDetailComponent,
    P404Component,
    AboutUsComponent
  ],
    imports: [
        BrowserModule,
        NgbModule,
        NoopAnimationsModule,
        AuthModule,
        StoreModule,

        MatSlideToggleModule,
        MatDialogModule,
        MatToolbarModule,
        MatIconModule,
        MatButtonModule,
        MatIconModule,

        AppRoutingModule,
    ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
