import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthServiceService } from '../auth-service.service';

@Component({
  selector: 'app-auth-register',
  templateUrl: './auth-register.component.html',
  styleUrls: ['./auth-register.component.css']
})
export class AuthRegisterComponent implements OnInit {

  constructor(public authservice: AuthServiceService, private router: Router) { }

  ngOnInit(): void {
  }

  onregister(registrationform: NgForm) {
    if (registrationform.valid) {
    this.authservice.register(registrationform.value.enteredusername, registrationform.value.enteredfirstname, registrationform.value.enteredsurname, registrationform.value.enteredpassword)
    registrationform.resetForm()
    alert('Returning to Signup...')
    this.router.navigate(['/signup']);
  }
  else {
    alert('Invalid!')
    return
  }}

  oncancel(registrationform: NgForm)
  {
    alert('Returning to Signup...')
    this.router.navigate(['/signup']);
  }

}
