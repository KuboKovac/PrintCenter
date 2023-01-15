import {Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {IProduct} from "../models/IProduct";
import {Basket, BasketItem} from "../models/Basket";

@Injectable({
  providedIn: 'root'
})
export class BasketService {

  private basket: Basket = new Basket()

  constructor(
    private http: HttpClient
  ) {
  }

  public sendOrder() {

  }

  public addToBasket(item: IProduct) {
    let product = this.basket.products.find(prod => prod.product.id === item.id)
    if (product) {
      this.changeAmount(item.id, product.amount + 1)
      return
    }
    this.basket.products.push(new BasketItem(item))
  }

  public removeFromBasket(itemId: number) {
    this.basket.products
      = this.basket.products.filter(prod => prod.product.id != itemId)
  }
  public getBasket() {
    return this.basket
  }

  public changeAmount(productId: number, amount: number) {
    let product = this.basket.products.find(prod => prod.product.id === productId)
    if (!product) {
      return
    }
    product.amount = amount
  }
}
