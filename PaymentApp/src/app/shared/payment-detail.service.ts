import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-detail.model';

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {

  constructor() { }

  readonly baseURL = 'http://localhost:39699/api/PaymentDetail'
  formData: PaymentDetail = new PaymentDetail();
}
