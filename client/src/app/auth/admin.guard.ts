import {Injectable} from '@angular/core';
import {CanActivate, Router} from '@angular/router';
import {JwtHelperService} from "@auth0/angular-jwt";
import {MessageService} from "../shared/message.service";

@Injectable({
  providedIn: 'root'
})
export class AdminGuard implements CanActivate {
  constructor(
    private router: Router,
    private msgService: MessageService
  ) {
  }
  jwtParser = new JwtHelperService()
  canActivate() {
    let token = localStorage.getItem('Jwt') || ''
    let decodedToken = this.jwtParser.decodeToken(token)


    if (decodedToken["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"] == 'Admin')
      return true
    else{
      this.router.navigateByUrl('home')
      this.msgService.message("You are not Authorised !", 5000)
      return false
    }
  }
}
