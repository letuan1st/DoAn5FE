import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { PhimListComponent } from '../phim/phim-list/phim-list.component';
import { Phim } from '../interface/phim';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';
import { PhimService } from '../services/phim.service';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor(private httpClient:HttpClient,private phimservice:PhimService,
    private router:Router) { }
  ListPhim: any;
  selectedPhim:Phim;
  phim$:Observable<Phim[]>;
  
 


onSelect(phim:Phim):void{
  this.selectedPhim=phim;
  this.router.navigateByUrl("/phim/" + phim.MaPhim);
}

  ngOnInit() {
    
    this.httpClient.get('https://localhost:5001/api/phim/getall').subscribe(respose=>{
      this.ListPhim=respose;
      console.log(this.ListPhim);
    });
  }

}
