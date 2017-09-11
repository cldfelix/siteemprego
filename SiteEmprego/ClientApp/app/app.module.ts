import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { VagaListaComponent } from './vaga-lista/vaga-lista.component';

@NgModule({
  declarations: [
    AppComponent,
    VagaListaComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
