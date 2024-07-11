import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  formData = {
    email: '',
    password: ''
  };
  errorMessage: string | null = null;

  constructor(private authService: AuthService, private router: Router) {}

  login() {
    this.authService.login(this.formData.email, this.formData.password)
      .subscribe(
        (response: any) => {
          console.log('Giriş başarılı:', response);
          this.errorMessage = null;
          this.router.navigate(['/admin']);
        },
        (error) => {
          console.error('Giriş hatası:', error);
          this.errorMessage = 'Giriş başarısız. Lütfen tekrar deneyin.';
        }
      );
  }
}
