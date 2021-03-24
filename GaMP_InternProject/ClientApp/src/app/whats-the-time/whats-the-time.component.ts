import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-whats-the-time',
  templateUrl: './whats-the-time.component.html'
})
export class WhatsTheTimeComponent {
  public forecasts: WhatsTheTime[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) { //here we set up component and baseurl
    http.get<WhatsTheTime[]>(baseUrl + 'whatsthetime').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}

interface WhatsTheTime {
  time: string;
}
