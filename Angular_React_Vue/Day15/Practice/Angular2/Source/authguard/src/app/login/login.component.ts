import { Component, OnInit } from '@angular/core';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  message: string;
  constructor(private authService: AuthService) {
    this.message = '';
   }

  ngOnInit(): void {
  }
   login(username: string, password: string): boolean {
    this.message = '';
    if (!this.authService.login(username, password)) {
      this.message = 'Incorrect credentials.';
    }
    return false;
  }

  logout(): boolean {
    this.authService.logout();
    return false;
  }

}
