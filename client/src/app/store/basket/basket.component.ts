import { Component, OnInit } from '@angular/core';
import {Basket} from "../models/Basket";
import {BasketService} from "../services/basket.service";
import {IProduct} from "../models/IProduct";

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.scss']
})
export class BasketComponent implements OnInit {

  public basket!: Basket

  constructor(
    public basketService: BasketService
  ) {
    this.setBasket()
  }

  ngOnInit(): void {
  }


  public increaseAmount(product: IProduct, amount: number){
    this.basketService.changeAmount(product.id, amount + 1)
    this.setBasket()
  }
  public decreaseAmount(product: IProduct, amount: number){
    if (amount <= 1){
      this.removeFromBasket(product)
      return
    }
    this.basketService.changeAmount(product.id, amount - 1)
    this.setBasket()
  }

  public removeFromBasket(product: IProduct){
    this.basketService.removeFromBasket(product.id)
    this.setBasket()
  }
  public setBasket(){
    this.basket = this.basketService.getBasket()
  }
}
