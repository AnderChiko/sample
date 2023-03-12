import { Injectable } from '@angular/core';
import { HttpHeaders, HttpParams, HttpClient  } from '@angular/common/http';
import { retry, timeout, catchError } from 'rxjs/operators';
import { Observable, of } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  public baseUrl: string = environment.apiBaseUrl;

  constructor(
                 private httpClient: HttpClient
             ) {
              }

public POST(url: string, model: object)
    {
        let fullUrl = this.baseUrl + url ;
        let bodyParams = JSON.stringify(model);
        let response = this.httpClient.post<any>(fullUrl,bodyParams)
                                      .pipe(retry(2),timeout(1000),
                                        catchError(e =>{
                                          return of(null);
                                      }));
        return response;
    }
}
