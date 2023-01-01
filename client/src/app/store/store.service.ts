import {Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {environment} from "../../environments/environment";
import {catchError} from "rxjs";
import {MessageService} from "../shared/message.service";
import {errHandler} from "../shared/functions";

@Injectable({
  providedIn: 'root'
})
export class StoreService {
  private url = environment.baseUrl
  constructor(
    private http: HttpClient,
    private msgService: MessageService
  ) { }

  public getAllProducts() {
    return this.http.get(this.url + 'Store/getAllProducts').pipe(
      catchError(err => errHandler(err,5000,this.msgService))
    )
  }
  public getCategories(){
    return this.http.get(this.url + 'Store/getCategories').pipe(
      catchError(err => errHandler(err,5000,this.msgService))
    )
  }
  public getBrands(){
    return this.http.get(this.url + 'Store/getBrands').pipe(
      catchError(err => errHandler(err,5000,this.msgService))
    )
  }


}
