import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';
import * as webix from 'webix';

import { AppComponent } from './app.component';
import { ScoreListComponent } from './score/scoreList.component';
//import { WebixComponent } from './score/webix.component';

@NgModule({
    imports: [BrowserModule, HttpModule, FormsModule],
    declarations: [AppComponent, ScoreListComponent],
    bootstrap: [AppComponent]
})
export class AppModule { }
