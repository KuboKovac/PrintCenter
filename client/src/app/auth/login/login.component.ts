import {Component, OnInit} from '@angular/core';
import {AuthService} from "../auth.service";
import {LoginModel} from "../models/loginModel";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  login: LoginModel = new LoginModel('','')

  constructor(private authService: AuthService) {
  }

  ngOnInit(): void {
  }

  public onSubmit() {
    //TODO service
  }
}
