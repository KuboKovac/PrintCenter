import { Component, OnInit } from '@angular/core';
import {StoreService} from "../services/store.service";
import {ActivatedRoute, Router} from "@angular/router";
import {IProduct} from "../models/IProduct";

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.scss']
})
export class ProductDetailComponent implements OnInit {

  private productId: string | null = null
  declare public product: IProduct

  constructor(
    private storeService: StoreService,
    private activatedRoute: ActivatedRoute,
  ) { }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(() => {
      this.productId = this.activatedRoute.snapshot.paramMap.get('detailId')
    })
    this.getProduct(this.productId)
  }


  private getProduct(id: string | null){
    this.storeService.getById(id).subscribe(data => {
      this.product = data
    })
  }
}
