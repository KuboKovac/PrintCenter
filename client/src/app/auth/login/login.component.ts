import {Component, OnInit} from '@angular/core';
import {AuthService} from "../auth.service";
import {LoginModel} from "../models/loginModel";
import {MatDialog} from "@angular/material/dialog";
import {Router} from "@angular/router";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  login: LoginModel = new LoginModel('','')

  constructor(
    private authService: AuthService,
    private dialog: MatDialog,
    private router: Router
    ) {
  }

  ngOnInit(): void {
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
