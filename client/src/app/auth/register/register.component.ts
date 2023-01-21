import {Component} from '@angular/core';
import {RegisterModel} from "../models/registerModel";
import {AuthService} from "../auth.service";
import {MatDialog} from "@angular/material/dialog";
import {Router} from "@angular/router";
import {AbstractControl, FormControl, FormGroup, ValidationErrors, Validators} from "@angular/forms";
import {inputFieldsMatch} from "../../../assets/validators/custom.validators";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {

  register: RegisterModel = new RegisterModel('', '', '', '', '');

  registerForm = new FormGroup({
    username: new FormControl('', [Validators.required,Validators.minLength(5)]),
    email: new FormControl('', [Validators.required ,Validators.email]),
    fName: new FormControl('',[Validators.required, Validators.minLength(2)]),
    lName: new FormControl('',[Validators.required, Validators.minLength(2)]),
    password: new FormControl('',[Validators.required,Validators.minLength(6)]),
    passwordValid: new FormControl('',[Validators.required,Validators.minLength(6)])
  },
    {
      validators: inputFieldsMatch('password','passwordValid')
    })
  constructor(
    private authService: AuthService,
    private dialog: MatDialog,
    private router: Router
  ) {
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
  private passwordValidator(formControl: AbstractControl): ValidationErrors | null{
    const password = formControl.get('password')?.value
    const passwordValid = formControl.get('passwordValid')?.value

    if (password === passwordValid){
      passwordValid.setErrors(null)
      return null
    }
    else{
      passwordValid.setErrors({passwordMatch: false})
      return {passwordMatch: false}
    }
  }
}
