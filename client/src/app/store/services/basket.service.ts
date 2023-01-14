import {Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {IBasketItem} from "../models/IBasket";
import {IProduct} from "../models/IProduct";

@Injectable({
  providedIn: 'root'
})
export class BasketService {

  private basket: IBasketItem[] = []

  constructor(
    private http: HttpClient
  )
  {}

  public addToBasket(item: IProduct) {

  }

  public removeFromBasket(item: IProduct) {

  }

  public sendOrder() {

  }

  public getBasket(){
    return this.basket
  }
}
