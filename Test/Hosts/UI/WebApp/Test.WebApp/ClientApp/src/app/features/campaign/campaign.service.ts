import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { ApiService } from '../../helpers/api.service';
import { Campaign } from './components/models/campaign.model';
import { CampaignResponse } from './components/models/campaignResponse.model';
@Injectable({
  providedIn: 'root'
})
export class CampaignService {

  constructor(private apiService: ApiService) {
  }

  public create(postObj: Campaign): Observable<CampaignResponse> {
    return this.apiService.POST("api/Message", postObj);
  }
}
