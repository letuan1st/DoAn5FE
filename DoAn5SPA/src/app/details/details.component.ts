import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Phim } from '../interface/phim';
import { PhimService } from '../services/phim.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class DetailsComponent implements OnInit {

  @Input() phim : Phim;
  constructor(
    private httpClient:HttpClient,
    private route:ActivatedRoute,
    private router:Router,
    private phimservice:PhimService
    ) { }
  

  ngOnInit() {
    let id= + this.route.snapshot.params['id'];
    this.phimservice.getPhimbyId(id).subscribe(result=>this.phim=result);
  }

}
