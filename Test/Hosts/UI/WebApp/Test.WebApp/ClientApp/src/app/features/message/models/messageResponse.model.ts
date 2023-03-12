import { Message } from "./message.model";

export class MessageResponse implements IMessageResponse {
  status!: number;
  data!: Message;
  message!: string;
}

export interface IMessageResponse {
  status: number;
  data: Message;
  message: string;
}
