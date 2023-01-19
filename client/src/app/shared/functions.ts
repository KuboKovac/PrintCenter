import {EMPTY, never, Observable} from "rxjs";
import {HttpErrorResponse} from "@angular/common/http";
import {MessageService} from "./message.service";

export function errHandler(err: any, timeout:number, msgService: MessageService): Observable<never> {
  if (err instanceof HttpErrorResponse) {
  if (err.status === 0) {
    msgService.message('Server not responding')
    console.error('Server not working')
    return EMPTY
  } else if (err.status < 500) {
    const msg = err.error
    msgService.message(msg, timeout)
    console.error(msg)
    return EMPTY
  }
}
return EMPTY
}
