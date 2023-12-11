import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})

export class AuthServiceService {

  private token!: string;

  constructor(private http: HttpClient) { }

  register(userusername:string, userfirstname:string, usersurname:string, userpassword:string)
  {
    this.http.post('https://localhost:7899/api/users/', {username:userusername, firstName:userfirstname, lastName:usersurname, password:userpassword})
    .subscribe(response =>{
    });
  }
  
  login(userusername:string, userpassword:string)
  {
    this.http.post<{token: string}>('https://localhost:7899/api/auth/', {username:userusername, password:userpassword})
    .subscribe(response =>{
      const token = response.token;
      this.token = token;
    });
  }

  getToken(){
    return this.token;
  }
  
}
