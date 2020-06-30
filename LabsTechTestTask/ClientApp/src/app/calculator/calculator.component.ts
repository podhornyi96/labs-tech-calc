import {Component, OnInit} from '@angular/core';
import {OperationType} from './shared/OperationType';
import {CalculationRequest} from './shared/calculator-request.model';
import {CalculatorService} from './shared/calculator.service';
import {CalculatorResponse} from './shared/calculator-response.model';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {

  request: CalculationRequest = new CalculationRequest();
  response: CalculatorResponse;

  operationTypes = [
    {key: OperationType.Add, value: '+'},
    {key: OperationType.Subtract, value: '-'},
    {key: OperationType.Divide, value: '/'},
    {key: OperationType.Multiply, value: '*'}
  ];

  constructor(public calculator: CalculatorService) {
  }

  ngOnInit() {
  }

  calculate(): void {
    this.calculator.calculate(this.request).subscribe((x: CalculatorResponse) => {
      this.response = x;
    });
  }

}
