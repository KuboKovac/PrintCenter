import {Injectable} from '@angular/core';
import {HttpClient, HttpErrorResponse} from "@angular/common/http";
import {LoginModel} from "./models/loginModel";
import {environment} from "../../environments/environment";
import {catchError, EMPTY, map, Observable} from "rxjs";
import {MessageService} from "./message.service";
import {TokenModel} from "./models/tokenModel";
import {RegisterModel} from "./models/registerModel";

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private url = environment.baseUrl

  constructor(
    private http: HttpClient,
    private msgService: MessageService
    ) { }

  set token(value: string | null){
    if (value){
      localStorage.setItem('Jwt', value)
    }
    else{
      localStorage.removeItem('Jwt')
    }
  }
  get token(): string | null{
    return localStorage.getItem('Jwt')
  }

  public login(login: LoginModel): Observable<TokenModel>{
    return this.http.post<TokenModel>(this.url + 'Auth/login', login).pipe(
      map(token  => {
        this.token = token.token
        this.msgService.message('Logged in successfully')
        return new TokenModel(this.token)
      }),
      catchError(err => this.errHandler(err))
    )
  }

  public register(register: RegisterModel): Observable<boolean>{
    return this.http.post(this.url + 'Auth/register', register, {responseType: 'text'}).pipe(
      map(response => {
        this.msgService.message(response, 7000)
        return true
      }),
      catchError(err => this.errHandler(err))
    )
  }

  private errHandler(err: any): Observable<never>{
    if (err instanceof HttpErrorResponse){
      if (err.status === 0){
        this.msgService.message('Server not responding')
        console.error('Server not working')
        return EMPTY
      }
      else if(err.status < 500){
        const msg = err.error
        this.msgService.message(msg,6000)
        console.error(msg)
        return EMPTY
      }
    }
    return EMPTY
  }

}
