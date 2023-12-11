import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PostServiceService {

  private postsdisplay:{_id:string,id:string,subject:string,description:string,departmentCode:string,__v:string}[]=[];
  private updatedpostsdisplay = new Subject<{_id:string,id:string,subject:string,description:string,departmentCode:string,__v:string}[]>();
  
  constructor(private http: HttpClient) { }

  addpost_service(pid:string, pdepartmentcode:string, psubject:string, pdescription:string){
    this.http.post<{message:string,post:any}>('https://localhost:7899/api/posts',{id:pid,departmentCode:pdepartmentcode,subject:psubject,description:pdescription})
    .subscribe((thepost) =>
    {
      this.postsdisplay.push(thepost.post);
      this.updatedpostsdisplay.next([...this.postsdisplay]);
    })
  }

  getpost_service(){
    this.http.get<{message:String,posts:any}>('https://localhost:7899/api/posts')
    .subscribe((thepost)=>
    {
      this.postsdisplay = thepost.posts
      this.updatedpostsdisplay.next([...this.postsdisplay]);
    })
  }

  deletepost_service(postid: string){
    this.http.delete('https://localhost:7899/api/posts/'+postid)
    .subscribe(()=>
    {
      const updatedpostsdeleted = this.postsdisplay.filter(post=>post._id!==postid);
      this.postsdisplay=updatedpostsdeleted;
      this.updatedpostsdisplay.next([...this.postsdisplay]);
    })
  }

  findpost_service(postid: string){
    this.http.get('https://localhost:7899/api/posts/'+postid)
    .subscribe(()=>
    {
      const updatedpostsfound = this.postsdisplay.filter(post=>post._id!==postid);
      this.postsdisplay=updatedpostsfound;
      this.updatedpostsdisplay.next([...this.postsdisplay]);
    })
  }

  getUpdateListener()
  {
    return this.updatedpostsdisplay.asObservable();
  }
}
