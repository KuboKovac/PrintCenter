import {Component} from '@angular/core';
import {AuthService} from "../auth.service";
import {LoginModel} from "../models/loginModel";
import {MatDialog} from "@angular/material/dialog";
import {Router} from "@angular/router";
import {FormControl, FormGroup, Validators} from "@angular/forms";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  login: LoginModel = new LoginModel('','')
  loginForm = new FormGroup({
    username: new FormControl('',[Validators.required]),
    password: new FormControl('', [Validators.required])
  })

  constructor(
    private authService: AuthService,
    private dialog: MatDialog,
    private router: Router
    ) {
  }
  public onSubmit() {
    this.authService.login(this.login).subscribe({
      next: success => {
        if (success){
          this.dialog.closeAll()
          this.router.navigateByUrl('/home')
        }
      }
    })
  }
}
