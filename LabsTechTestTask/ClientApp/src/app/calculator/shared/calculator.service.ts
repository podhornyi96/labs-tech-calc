import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {environment} from '../../../environments/environment';
import {CalculationRequest} from './calculator-request.model';
import {CalculatorResponse} from './calculator-response.model';

@Injectable({
  providedIn: 'root'
})
export class CalculatorService {

  constructor(public http: HttpClient) {
  }

  calculate(request: CalculationRequest): Observable<CalculatorResponse> {
    return this.http.get<CalculatorResponse>(`${environment.apiUrl}/api/calculator?operator1=${request.operator1}&operand=${request.operand}&operator2=${request.operator2}`);
  }

}
