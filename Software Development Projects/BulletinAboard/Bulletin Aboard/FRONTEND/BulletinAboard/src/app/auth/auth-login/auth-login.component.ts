import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { AuthServiceService } from '../auth-service.service';

@Component({
  selector: 'app-auth-login',
  templateUrl: './auth-login.component.html',
  styleUrls: ['./auth-login.component.css']
})
export class AuthLoginComponent implements OnInit {

  constructor(public authservice: AuthServiceService, private router: Router) { }

  onlogin(loginform: NgForm)
  {
    if(loginform.valid)
    {
    this.authservice.login(loginform.value.enteredusername,loginform.value.enteredpassword)
    loginform.resetForm()
    alert('Welcome user! Logging in...')
    this.router.navigate(['/home']);
    } 
    else {
      alert('Invalid Credentials!')
      return
    }
  }

  oncancel(loginform: NgForm)
  {
    alert('Returning to Signup...')
    this.router.navigate(['/signup']);
  }

  ngOnInit(): void {
  }

}
