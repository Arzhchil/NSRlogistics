import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { MapComponent } from './components/map/map.component';
import { LeafletModule } from '@asymmetrik/ngx-leaflet';
import { FileDropzonePageComponent } from './components/file-dropzone-page/file-dropzone-page.component';
import { ListShipsPageComponent } from './components/list-ships-page/list-ships-page.component';
import { GanttChartPageComponent } from './components/gantt-chart-page/gantt-chart-page.component';
import { MainComponent } from './components/main/main.component';
import { NavigationComponent } from './shared/components/navigation/navigation.component';
import { DropzoneComponent } from './shared/components/dropzone/dropzone.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    MapComponent,
    FileDropzonePageComponent,
    ListShipsPageComponent,
    GanttChartPageComponent,
    MainComponent,
    NavigationComponent,
    DropzoneComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    LeafletModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
