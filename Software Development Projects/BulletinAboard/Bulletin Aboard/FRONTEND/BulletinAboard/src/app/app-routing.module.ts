import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AuthLoginComponent } from "./auth/auth-login/auth-login.component";
import { AuthRegisterComponent } from "./auth/auth-register/auth-register.component";
import { HomeComponent } from "./home/home.component";
import { PostCreateComponent } from "./post/post-create/post-create.component";
import { PostDisplayComponent } from "./post/post-display/post-display.component";
import { SignInComponent } from "./sign-in/sign-in.component";

const routes: Routes =[
    {path: 'signup', component:SignInComponent},
    {path: 'register', component:AuthRegisterComponent},
    {path: 'login', component:AuthLoginComponent},
    {path: 'home', component:HomeComponent},
    {path: 'create', component:PostCreateComponent},
    {path: 'display', component:PostDisplayComponent}
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule{}