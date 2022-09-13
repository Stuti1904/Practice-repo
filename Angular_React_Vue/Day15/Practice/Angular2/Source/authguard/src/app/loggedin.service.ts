import { Injectable } from '@angular/core';
import { AuthService } from './auth.service';
import { CanActivate } from '@angular/router';
@Injectable({
  providedIn: 'root'
})
export class LoggedinService {
  constructor(private authService: AuthService) {}
  canActivate(): boolean {
    return this.authService.isLoggedIn();
  }
}
