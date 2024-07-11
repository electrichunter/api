import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private apiUrl = 'https://localhost:7272/api/Controlgazi/login'; // API URL'nizi doğru şekilde ayarlayın

  constructor(private http: HttpClient) {}

  login(email: string, password: string): Observable<any> {
    const payload = { email, password };
    return this.http.post<any>(this.apiUrl, payload); // API URL'yi burada doğru şekilde kullanın
  }
}
