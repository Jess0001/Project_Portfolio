import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { PostServiceService } from '../post-service.service';

@Component({
  selector: 'app-post-create',
  templateUrl: './post-create.component.html',
  styleUrls: ['./post-create.component.css']
})
export class PostCreateComponent implements OnInit {

  constructor(public postservice: PostServiceService, private router: Router) { }

  ngOnInit(): void {
  }

  oncreatepost(postform: NgForm){
    if (postform.invalid){
      alert('Invalid Post!')
      return
    }
    alert(postform.value.idref+'\n'+postform.value.enterdepartmentcode+'\n'+postform.value.enteredsubject+'\n'+postform.value.enterdescription)
    alert('Creating post! Returning to home page...')
    this.postservice.addpost_service(postform.value.idref,postform.value.enterdepartmentcode,postform.value.enteredsubject,postform.value.enterdescription)
    postform.resetForm()
    this.router.navigate(['/home']);
  }
  
  oncancel(postform: NgForm){
    alert('Returning to home page...') 
    this.router.navigate(['/home']);
  }
}
