import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Subscription } from 'rxjs';
import { PostServiceService } from '../post-service.service';

@Component({
  selector: 'app-post-display',
  templateUrl: './post-display.component.html',
  styleUrls: ['./post-display.component.css']
})
export class PostDisplayComponent implements OnInit {

  posts:{_id:string,id:string,subject:string,description:string,departmentCode:string,__v:string}[]=[];

  constructor(private postservice: PostServiceService) { }

  private postsubscription!: Subscription;

  ngOnInit(){
    this.postservice.getpost_service();
    this.postsubscription = this.postservice.getUpdateListener()
  .subscribe((posts:{_id:string,id:string,subject:string,description:string,departmentCode:string,__v:string}[])=>
  {
    this.posts = posts;
  });
  }

  ngOnDestroy()
  {
    this.postsubscription.unsubscribe();
  }

  ondelete(postid:string)
  {
    this.postservice.deletepost_service(postid)
  }

  onfind(postid:string)
  {
    this.postservice.findpost_service(postid)
  }
}
