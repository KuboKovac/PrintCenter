import { Component, OnInit } from '@angular/core';
import {MatDialog} from "@angular/material/dialog";
import {LoginComponent} from "../../auth/login/login.component";
import {RegisterComponent} from "../../auth/register/register.component";
import {AuthService} from "../../auth/auth.service";

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {

  username: string = ''
  constructor(
    private dialog: MatDialog,
    private authService: AuthService
  ) { }

  ngOnInit(): void {
    this.username = this.authService.username
    this.authService.usernameChanges().subscribe(
      username => this.username = username)
  }

  public login(){
    this.dialog.open(LoginComponent, {
      panelClass: 'custom-modal-box'
    })
  }
  public logout(){
    this.authService.logout()
  }
  public register(){
    this.dialog.open(RegisterComponent, {
      panelClass: 'custom-modal-box'
    })
  }
}
