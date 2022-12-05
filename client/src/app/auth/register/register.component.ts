import {Component, OnInit} from '@angular/core';
import {RegisterModel} from "../models/registerModel";
import {AuthService} from "../auth.service";
import {MatDialog} from "@angular/material/dialog";
import {Router} from "@angular/router";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  register: RegisterModel = new RegisterModel('', '', '', '', '');

  constructor(
    private authService: AuthService,
    private dialog: MatDialog,
    private router: Router
  ) {
  }

  ngOnInit(): void {
  }

  public onSubmit() {
    this.authService.register(this.register).subscribe({
      next: success => {
        if (success){
          this.dialog.closeAll()
          this.router.navigateByUrl('/home')
        }
      }
    })
  }


}
