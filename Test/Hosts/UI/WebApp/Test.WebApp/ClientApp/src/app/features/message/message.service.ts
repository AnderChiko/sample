import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from '../../helpers/api.service';
import { Message } from './models/message.model';
import { MessageResponse } from './models/messageResponse.model';

@Injectable({
  providedIn: 'root'
})
export class MessageService {

  constructor(private apiService: ApiService, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
  }

  public create(postObj: Message): Observable<MessageResponse> {

    //this.http.get<MessageResponse[]>(this.baseUrl + 'Message').subscribe(result => {
    //  return  result;
    //}, error => console.error(error));

    return this.apiService.POST("api/Message", postObj);
  }
}
