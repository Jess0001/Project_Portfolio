import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppComponent } from './app.component';
import { SignInComponent } from './sign-in/sign-in.component';
import { HomeComponent } from './home/home.component';
import { PostCreateComponent } from './post/post-create/post-create.component';
import { PostDisplayComponent } from './post/post-display/post-display.component';
import { AuthLoginComponent } from './auth/auth-login/auth-login.component';
import { AuthRegisterComponent } from './auth/auth-register/auth-register.component';
import { AuthInterceptorInterceptor } from './auth/auth.interceptor.interceptor';
import { AppRoutingModule } from './app-routing.module';
import { ErrorComponent } from './error/error/error.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatDialogModule } from '@angular/material/dialog';
import { ErrorinterceptorInterceptor } from './error/errorinterceptor.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    SignInComponent,
    HomeComponent,
    PostCreateComponent,
    PostDisplayComponent,
    AuthLoginComponent,
    AuthRegisterComponent,
    ErrorComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatDialogModule
  ],
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: AuthInterceptorInterceptor, multi: true },
              { provide: HTTP_INTERCEPTORS, useClass: ErrorinterceptorInterceptor, multi: true }],
  bootstrap: [AppComponent]
})
export class AppModule {}
