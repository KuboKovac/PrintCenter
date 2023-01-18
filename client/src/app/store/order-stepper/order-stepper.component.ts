import { Component, OnInit } from '@angular/core';
import {Basket} from "../models/Basket";
import {BasketService} from "../services/basket.service";
import {Order} from "../models/Order";
import {FormControl, FormGroup, Validators} from "@angular/forms";
import {Router} from "@angular/router";
import {MessageService} from "../../shared/message.service";

@Component({
  selector: 'app-order-stepper',
  templateUrl: './order-stepper.component.html',
  styleUrls: ['./order-stepper.component.scss']
})
export class OrderStepperComponent implements OnInit {

  public selectedShipment: number = 0
  public accTransfer: boolean = true
  public payAfterDelivery: boolean = false
  public additionalPrice: number = 0

  public basket: Basket = new Basket()
  public orderData: Order = new Order()

  constructor(
    private basketService: BasketService,
    private router: Router,
    private messageService: MessageService
  ) {
  }

  ngOnInit(): void {
    this.basket = this.basketService.getBasket()
    this.calcAdditionalPrice()
  }

  public sendOrder(){
    this.basketService.sendOrder()
    this.router.navigateByUrl('/store/basket/order-success')
    this.messageService.message('Order created successfully',5000)
  }

  public selectShipment(id: number){
    this.selectedShipment = id
    this.calcAdditionalPrice()
  }

  public onCheckboxChange(){
    if (this.accTransfer){
      this.accTransfer = false
      this.payAfterDelivery = true
      this.calcAdditionalPrice()
    }
    else if (this.payAfterDelivery){
      this.accTransfer = true
      this.payAfterDelivery = false
      this.calcAdditionalPrice()
    }
  }
  private calcAdditionalPrice(){
    switch (this.selectedShipment){
      case 0:{
        this.additionalPrice = 3.50
        if (this.payAfterDelivery){
          this.additionalPrice += 1.50
        }
        break
      }
      case 1:{
        this.additionalPrice = 4.50
        if (this.payAfterDelivery){
          this.additionalPrice += 1.50
        }
        break
      }
      case 2:{
        this.additionalPrice = 0
        break
      }
    }
  }

  shippingForm = new FormGroup({
    fname: new FormControl('',[Validators.required, Validators.minLength(2)]),
    lname: new FormControl('',[Validators.required, Validators.minLength(2)]),
    email: new FormControl('',[Validators.required, Validators.email]),
    phoneNumber: new FormControl('',[Validators.required, Validators.minLength(9)]),
    address: new FormControl('',[Validators.required]),
    apartmentNo: new FormControl('',[Validators.required]),
    postalCode: new FormControl('',[Validators.required, Validators.minLength(3)]),
    province: new FormControl(''),
    country: new FormControl('',[Validators.required]),
  })
}
