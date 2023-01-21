import { Component, OnInit } from '@angular/core';
import {StoreService} from "../services/store.service";
import {ActivatedRoute, Router} from "@angular/router";
import {IImage, IProduct} from "../models/IProduct";
import {BasketService} from "../services/basket.service";
import {MessageService} from "../../shared/message.service";

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.scss']
})
export class ProductDetailComponent implements OnInit {

  private productId: string | null = null
  declare public product: IProduct
  declare public images: IImage[]
  declare public selectedImage: IImage
  constructor(
    private storeService: StoreService,
    private activatedRoute: ActivatedRoute,
    private basketService: BasketService,
    private msgService: MessageService
  ) { }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(() => {
      this.productId = this.activatedRoute.snapshot.paramMap.get('detailId')
    })
    this.getProduct(this.productId)
  }

  public addToBasket(product: IProduct){
      this.basketService.addToBasket(product)
    this.msgService.message("Product added into basket",2000)
  }

  public changeImage(image: IImage){
    this.selectedImage = image
  }

  private getProduct(id: string | null){
    this.storeService.getById(id).subscribe(data => {
      this.product = data
      this.images = data.images
      this.selectedImage = data.images[0]
    })
  }
}
