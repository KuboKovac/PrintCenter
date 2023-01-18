import {IProduct} from "./IProduct";

export class Basket{
  public products: BasketItem[] = []

  get totalPrice(){
    let totalPrice = 0
    this.products.forEach(prod => {
      totalPrice += prod.price
    })
    return totalPrice
  }
}

export class BasketItem {
  constructor(product: IProduct) {
    this.product = product
    this.price
  }
  public amount: number = 1
  public product: IProduct

  get price(): number{
      return this.product.price * this.amount
  }
}

