import {Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {environment} from "../../environments/environment";
import {catchError, map, Observable, of} from "rxjs";
import {MessageService} from "../shared/message.service";
import {errHandler} from "../shared/functions";
import {IBrand} from "./models/IBrand";
import {ICategory} from "./models/ICategory";
import {IProduct} from "./models/IProduct";

@Injectable({
  providedIn: 'root'
})
export class StoreService {
  private url = environment.baseUrl

  constructor(
    private http: HttpClient,
    private msgService: MessageService
  ) {}

  public getAllProducts(): Observable<IProduct[]> {
    return this.http.get(this.url + 'Store/getAllProducts').pipe(
      map(response => {
        return response as IProduct[]
      }),catchError(err => errHandler(err,5000, this.msgService))
    )
  }
  public getByCategory(categoryName: string | null): Observable<IProduct[]>{
    return this.http.get(this.url + 'Store/getByCategory/' + categoryName).pipe(
      map(response =>{
        return response as IProduct[]
      }),catchError(err => errHandler(err,5000, this.msgService))
    )
  }
  public getByBrand(brandName: string | null) : Observable<IProduct[]>{
    return this.http.get(this.url + 'Store/getByBrand/' + brandName).pipe(
      map(response => {
        return response as IProduct[]
        }),catchError(err => errHandler(err,5000, this.msgService))
    )
  }
  public getCategories(): Observable<ICategory[]>{
    return this.http.get(this.url + 'Store/getCategories').pipe(
      map(response => {
        return response as ICategory[]
      }),catchError(err => errHandler(err,5000,this.msgService))
    )
  }
  public getBrands(): Observable<IBrand[]> {
    return this.http.get(this.url + 'Store/getBrands').pipe(
      map(response => {
        return response as IBrand[]
      }),catchError(err => errHandler(err,5000,this.msgService))
    )
  }

}
