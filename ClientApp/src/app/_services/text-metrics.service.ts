import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';


@Injectable({ providedIn: 'root' })
export class TextMetricsService {
    private serviceUrl = 'https://localhost:44397/textmetrics';

    constructor(private http: HttpClient) {
    }

    public GetMetrics(TextForm: FormData): Observable<TextMetrics> {
      return this.http.post<TextMetrics>(this.serviceUrl, TextForm);
    }
}
