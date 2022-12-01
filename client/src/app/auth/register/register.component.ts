import { Component, OnInit } from '@angular/core';
import {RegisterModel} from "../models/registerModel";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  register: RegisterModel = new RegisterModel('','','','','');

  constructor() { }

  ngOnInit(): void {
  }

  public onSubmit(){
    //TODO
  }


}
