import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CampaignService } from '../../campaign.service';
import { Campaign } from '../models/campaign.model';
import { CampaignResponse } from '../models/campaignResponse.model';

@Component({
  selector: 'app-campaign-details',
  templateUrl: './campaign-details.component.html'
})
export class CampaignDetailsComponent implements OnInit {

  @Input() MessageCode!: number;

  detailForm!: FormGroup;
  Submitted: boolean = false;

  campaignResponse!:CampaignResponse;
  request!: Campaign;

  constructor(public _formBuilder: FormBuilder, public campaignService: CampaignService) { }

  ngOnInit() {
    this.createForm();
  }

  public get P1() { return this.detailForm.controls; }

  get name() {
    return this.detailForm.get('name');
  }

  public createForm() {
    this.detailForm = this._formBuilder.group({
      Name: ['', Validators.required],
      Description: ['', Validators.required],
      Active: [false, Validators.required],
    })
  }

  public save(): void {

    this.Submitted = true;

    if (this.detailForm.invalid)
      return;

    this.request = this.mapDetailsToFormControls();

    this.campaignService.create(this.request).subscribe(
      (response) => {
        if (response === null || response.message === 'Error') {
          return;
        }

        this.campaignResponse = response;
      });

  }

  private mapDetailsToFormControls(): Campaign {

    return {
      code: 0,
      MessageCode : this.MessageCode,
      name: this.P1.name.value,
      description: this.P1.description.value,
      active: this.P1.active.value,
    }

  }
}
