export class Order{
  constructor(
    public fName: string = '',
    public lName: string = '',
    public email: string = '',
    public phoneNumber: number = 0,
    public address: string = '',
    public apartmentNo: number = 0,
    public postalCode: number = 0,
    public province?: string,
    public country: string = '',
    ) {
  }
}
