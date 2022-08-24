export class MsgList {
  id: number;
  visibility: boolean;
  name: string;
  sensorNo: string;
  time: string;
  objectType: string;
  address: number;
  constructor(id: number, name: string, sensorNo: string, time: string, objectType: string, address: number) {
    this.id = id;
    this.visibility = true;
    this.name = name;
    this.sensorNo = sensorNo;
    this.time = time;
    this.objectType = objectType;
    this.address = address;
  }
  public reverseVisibility() {
    this.visibility = !this.visibility;
  }
}

export interface ErrorMessage{
  name: string;
  sensorNo: string;
  time: string;
  objectType: string;
  address: number;
}

export enum Status{
  defined = 1,
  current,
  blocked,
}
