export class Message implements IMessage {

  code!: number;
  name!: string;
  description!: string;
  active!: boolean;

}

export interface IMessage {

  code: number;
  name: string;
  description: string;
  active: boolean;

}
