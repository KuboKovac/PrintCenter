import {Injectable} from '@angular/core';
import {HttpClient, HttpErrorResponse} from "@angular/common/http";
import {LoginModel} from "./models/loginModel";
import {environment} from "../../environments/environment";
import {catchError, map, Observable, Subject} from "rxjs";
import {MessageService} from "../shared/message.service";
import {TokenModel} from "./models/tokenModel";
import {RegisterModel} from "./models/registerModel";
import {Router} from "@angular/router";
import {errHandler} from "../shared/functions";
import {JwtHelperService} from "@auth0/angular-jwt";

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private url = environment.baseUrl
  usernameSubject = new Subject<string>()
  private jwtParser = new JwtHelperService();
  public isAdmin: boolean = false

  constructor(
    private http: HttpClient,
    private msgService: MessageService,
    private router: Router,
  ) {
  }

  set token(value: string | null) {
    if (value) {
      localStorage.setItem('Jwt', value)
    } else {
      localStorage.removeItem('Jwt')
    }
  }

  get token(): string | null {
    return localStorage.getItem('Jwt')
  }

  set username(value: string) {
    if (value) {
      localStorage.setItem('username', value)
    } else {
      localStorage.removeItem('username')
    }
    this.usernameSubject.next(value)
  }
  get username(): string {
    return localStorage.getItem('username') || '';
  }
  public usernameChanges(): Observable<string>{
    return this.usernameSubject.asObservable()
  }

  public login(login: LoginModel): Observable<TokenModel> {
    return this.http.post<TokenModel>(this.url + 'Auth/login', login).pipe(
      map(response => {
        this.username = response.username
        this.token = response.token

        let parsedToken = this.jwtParser.decodeToken(this.token)
        if (parsedToken["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"] == 'Admin'){
          this.isAdmin = true
        }
        else
          this.isAdmin = false

        this.msgService.message('Logged in successfully')
        return new TokenModel(this.token)
      }),
      catchError(err => errHandler(err,5000,this.msgService))
    )
  }
  public logout(){
    this.username = ''
    this.token = ''
    this.router.navigateByUrl('/')
  }
  public register(register: RegisterModel): Observable<boolean> {
    return this.http.post(this.url + 'Auth/register', register, {responseType: 'text'}).pipe(
      map(response => {
        this.msgService.message(response, 7000)
        return true
      }),
      catchError(err => errHandler(err,5000,this.msgService))
    )
  }

}
