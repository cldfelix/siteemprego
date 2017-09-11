import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppVagaComponent } from './app-vaga/app-vaga.component';

@NgModule({
  declarations: [
    AppComponent,
    AppVagaComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
