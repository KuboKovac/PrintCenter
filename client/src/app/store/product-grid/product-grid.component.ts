import {Component, OnInit} from '@angular/core';
import {ActivatedRoute} from "@angular/router";
import {StoreService} from "../services/store.service";
import {IProduct} from "../models/IProduct";
import {PageEvent} from "@angular/material/paginator";
import {BasketService} from "../services/basket.service";
import {MessageService} from "../../shared/message.service";

@Component({
  selector: 'app-product-grid',
  templateUrl: './product-grid.component.html',
  styleUrls: ['./product-grid.component.scss'],
})
export class ProductGridComponent implements OnInit {
  private categories: string[] = []
  private brands: string[] = []

  public gridId: string | null = ''
  public products: IProduct[] = []
  public pageSlice: IProduct[] = []


  constructor(
    private activatedRoute: ActivatedRoute,
    private storeService: StoreService,
    private basketService: BasketService,
    private messageService: MessageService
  ) {
  }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe(params => {
      this.gridId = this.activatedRoute.snapshot.paramMap.get('id')
      this.getBrandsCategories()
      setTimeout(() => {
        if (this.categories.includes(<string>this.gridId)) {
          this.getByCategory(this.gridId)
        }
        else if (this.brands.includes(<string>this.gridId)) {
          this.getByBrand(this.gridId)
        }
        else {
          this.getProducts()
        }
        setTimeout(() => this.pageSlice = this.products.slice(0,12),500)
      }, 500)
    })
  }
  public addToBasket(product: IProduct){
    this.basketService.addToBasket(product)
    this.messageService.message("Product added to basket :)", 2000)
  }

  public onPaginatorChange(event: PageEvent){
    const startIdx = event.pageIndex * event.pageSize
    let endIdx = startIdx + event.pageSize
    if (endIdx > this.products.length){
      endIdx = this.products.length
    }
    this.pageSlice = this.products.slice(startIdx,endIdx)
  }

  private getBrandsCategories() {
    this.storeService.getBrands().subscribe(data => {
      this.brands = data.map(brand => brand.name)
    })
    this.storeService.getCategories().subscribe(data => {
      this.categories = data.map(cat => cat.name)
    })
  }

  private getProducts() {
    this.storeService.getAllProducts().subscribe(data => {
      this.products = data
    })
  }

  private getByCategory(id: string | null) {
    this.storeService.getByCategory(id).subscribe(data => {
      this.products = data
    })
  }

  private getByBrand(id: string | null) {
    this.storeService.getByBrand(id).subscribe(data => {
      this.products = data
    })
  }
}
