import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule} from '@angular/common/http';
import { AppComponent } from './app.component';

import { HeaderComponent } from './shared/header/header.component';
import { FooterComponent } from './shared/footer/footer.component';
import { HomeComponent } from './home/home.component';
import { DetailsComponent } from './details/details.component';
import { AppRouting } from './app.routing';
import { FormsModule } from '@angular/forms';
import { PhimListComponent } from './phim/phim-list/phim-list.component';

@NgModule({
  declarations: [				
    AppComponent,
    
      HeaderComponent,
      FooterComponent,
      HomeComponent,
      DetailsComponent,
      
      PhimListComponent
      
   ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRouting,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
