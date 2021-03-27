import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';


@Component({
  selector: 'app-whats-the-time',
  templateUrl: './whats-the-time.component.html'
})
export class WhatsTheTimeComponent {
  public forecasts: WhatsTheTime[];
  public binaryString = null;
  private httpClient: HttpClient;
  private baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.httpClient = http;
    this.baseUrl = baseUrl;
  }

  public process() {
    this
      .httpClient
      .get<WhatsTheTime[]>(this.baseUrl + 'api/WhatsTheTime/x?bins=' + this.binaryString)
      .subscribe(httpResult => {
        this.forecasts = httpResult;
        console.log(httpResult)
      })

  }  
}

interface WhatsTheTime {
  time: string;
}
