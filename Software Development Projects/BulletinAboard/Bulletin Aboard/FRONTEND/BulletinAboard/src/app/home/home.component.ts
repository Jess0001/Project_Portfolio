import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthServiceService } from '../auth/auth-service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(public authservice:AuthServiceService, private router:Router) { }

  ngOnInit(): void {
  }

  ondisplay()
  {
    this.router.navigate(['/display']);
  }

  onadd()
  {
    this.router.navigate(['/create']);
  }

  onlogout()
  {
    this.router.navigate(['/signup']);
  }

}
