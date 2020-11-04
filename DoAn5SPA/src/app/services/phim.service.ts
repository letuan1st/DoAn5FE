import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Phim } from '../interface/phim';
import { flatMap, first, shareReplay } from 'rxjs/operators';
@Injectable({
    providedIn:'root'
})

export class PhimService{
    constructor(private http:HttpClient){}
    private baseUrl: string = "/api/phim/GetAll";
    private PhimUrl: string = "/api/phim/AddPhim";
    private UpdateUrl: string = "/api/phim/UpdatePhim";
    private DeleteUrl: string = "/api/phim/DetelePhim";
    private phim$:Observable<Phim[]>;

    getPhim():Observable<Phim[]>{
      if(!this.phim$){
        this.phim$=this.http.get<Phim[]>(this.baseUrl).pipe(shareReplay());
      }
      return this.phim$;
    }
    getPhimbyId(id:number):Observable<Phim>{
      return this.getPhim().pipe(flatMap(result=>result),first(phim=>phim.MaPhim==id));
    }
    insertPhim(newPhim:Phim):Observable<Phim>{
      return this.http.post<Phim>(this.PhimUrl,newPhim);
    }
    updatePhim(id:number, editPhim:Phim):Observable<Phim>{
      return this.http.put<Phim>(this.UpdateUrl + id,editPhim);
    }
    deletePhim(id:number):Observable<any>{
      return this.http.delete<Phim>(this.DeleteUrl + id);
    }
    
    /* clearCache(){
      this.phim$=null;
    } */
}