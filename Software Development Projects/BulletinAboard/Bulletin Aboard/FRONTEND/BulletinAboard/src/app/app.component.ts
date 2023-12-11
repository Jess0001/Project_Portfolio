import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Bulletin Aboard';

  display = true;

  onopen()
  {
    this.display= false;
  }
}
