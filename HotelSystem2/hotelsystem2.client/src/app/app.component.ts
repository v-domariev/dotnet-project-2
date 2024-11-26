import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Hotel } from '../DTOs/hotel';

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  public forecasts: WeatherForecast[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getForecasts();
    this.getHotels();
  }

  getForecasts() {
    this.http.get<WeatherForecast[]>('/weatherforecast').subscribe(
      (result) => {
        this.forecasts = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }


  public hotels: Hotel[] = [];
  getHotels() {
    console.log("getHotels()");
    // this.http.get<Hotel[]>('/api/hotel2').subscribe(
    // this.http.get('/api/hotel2').subscribe(
    this.http.get<Hotel[]>('/weatherforecast/hotel3').subscribe(
      (result) => {

        // console.log("res: ", result);
        this.hotels = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  title = 'hotelsystem2.client';
}
