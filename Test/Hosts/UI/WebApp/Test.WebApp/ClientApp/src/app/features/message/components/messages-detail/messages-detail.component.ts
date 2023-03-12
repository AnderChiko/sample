import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MessageService } from '../../message.service';
import { Message } from '../../models/message.model';
import { MessageResponse } from '../../models/messageResponse.model';

@Component({
  selector: 'app-messages-detail',
  templateUrl: './messages-detail.component.html'
})
export class MessagesDetailComponent implements OnInit {

  detailForm!: FormGroup;
  messageResponse!: MessageResponse;
  messageRequest!: Message;

  private Submitted: boolean = false;

  constructor(public _formBuilder: FormBuilder, public messageService: MessageService) { }

  ngOnInit() {
    this.createForm();


    this.messageRequest = new Message();
    this.messageRequest.code = 0;
    this.messageResponse.data = this.messageRequest;
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

    this.messageRequest = this.mapDetailsToFormControls();

    this.messageService.create(this.messageRequest).subscribe(
      (response) => {
        if (response === null || response.message === 'Error') {
          return;
        }

        this.messageResponse = response;
      });

  }

  private mapDetailsToFormControls(): Message {

    return {
      code: 0,
      name: this.P1.name.value,
      description: this.P1.description.value,
      active: this.P1.active.value,
    }

  }
}

