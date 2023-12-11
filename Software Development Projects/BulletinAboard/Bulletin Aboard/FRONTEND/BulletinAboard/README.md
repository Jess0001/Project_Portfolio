# BulletinAboard
Bulletin Aboard is a web application developed for the government to communicate using posts to inform the involved department area(s) of probable or current issues ithin their sector.
This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 14.2.7.

## Languages
Different languages were used to create the application as a whole.

  ### Backend
  JavaScript was the main language used within the backend. JSON was used to install packages.

  ### Frontend
  For the web layout, the use of html and css were combined with typescript as the main language used for the code of the services and authorisation interceptor and to communicate with the backend along with a bit of JavaScript for the configuration. JSON was also used to install packages.

## Packages
Different packages were installed to create the application as a whole.

  ### Backend
  •bcrypt
  •cors
  •dotenv
  •dotnet
  •express
  •express-brute
  •helmet
  •hsts
  •joi
  •jsonwebtoken
  •middleware
  •mongoose
  •morgan

  ### Frontend
  •typescript
  •angular
  •karma

## Theme
The theme is more playful than one expects a government web application to be. The first reason is because although dealing with the issues of the public is serious, the view of this website may be a refreshing sight after a long day so that the sight may make you see things more light-hearted and calmly, hence addressing issues in a gentle way. The second reason is for discrete matters. Hence, it is not completely obvious that this is a government website to complete outsiders for simple security purposes.

## Background Image References
Login:		      (wallpaperswide.com, 2022)
Register:	      (wallpaperswide.com, 2022)
Signup: 		    (prezi, 2022)
Home: 		      (pikwizard, 2022)
Create Post:	  (bing, 2022)
Display Posts:  (bing, 2022)


## Tools and Requirements
•Visual Studio Code (2019 version)
•Insomnia.core
•Windows 10
•MongoDB (web as minimum)
•Microsoft Edge (Internet)
•Preferably 21.5 inch screen to display design layout properly

## Testing
Do note the backend server and frontend server needs to be running simultaneously. Follow the instructions below:

  ### Backend
  1. Open Visual Studio Code.
  2. Select 'Open Folder'.
  3. Select the 'BACKEND' folder in the 'Bulletin Aboard' folder.
  4. Open a new terminal by the menu item 'Terminal'.
  5. In the terminal, type `npm run dev` or `npm run start` and press enter.
  6. If the output in the terminal says "CONNECTED:-)" you are now connected to   the backend server.
  7. To test backend alone, open Insomnia.
  8. Provide the HTTP requests as specified in test.http and more specifically in the screenshot of the backed section of the testing document.
  9. Send requests as specified in testing document.

  ### Frontend
  1. Open Visual Studio Code.
  2. Select 'Open Folder'.
  3. Select the 'BulletinAboard' folder in the 'FRONTEND' folder of the 'Bulletin Aboard' folder.
  4. Open a new terminal by the menu item 'Terminal'.
  5. In the terminal, type `ng serve --o` and press enter.
  6. The server should then immediately open a new browser window, `http://localhost:4200/`.
  7. Refer to the Testing Documentation for images on the following instructions.
  8. A link appears, click on that link to go to the signup page
  9. Chose to register or login provided the buttons. To log in the user must be registered, if account does not exist the user will have to register an account first.
  10. Once the user is logged in they are taken to the home page. The user can view posts(view, get one or delete on in this component), create a post or sign out. Navigate to preferred option.
  11. To create a post, fill in the textboxes and click the specified button. To view posts, navigate to desired buttons. if signed out, user will be taken back to signup page. 

Do also take note that when testing is complete, type keyboard keys 'ctrl + c' to close both servers. In the backend, after typing keyboard keys 'ctrl + c', type 'y' to close server copletely.

## Updates
We have improved our backend and are glad to say that it is now fully functional.
We have also added a frontend for our backend to communicate with and provide an interface for the user to communicate with.

## Issues
We are currently facing issues within the communication between the frontend and backend so frontend values do not save to the database.

## References
References
Angular, 2022. ng generate. [Online] 
Available at: https://angular.io/cli/generate
[Accessed 5 Nov 2022].
Angular, 2022. NgForm. [Online] 
Available at: https://angular.io/api/forms/NgForm
[Accessed 5 Nov 2022].
Angular, 2022. Server-side rendering (SSR) with Angular Universal. [Online] 
Available at: https://angular.io/guide/universal
[Accessed 5 Nov 2022].
Angular, 2022. Setting up the local environment and workspace. [Online] 
Available at: https://angular.io/guide/setup-local#setting-up-the-local-environment-and-workspace
[Accessed 5 Nov 2022].
Angular, 2022. View encapsulation. [Online] 
Available at: https://angular.io/guide/view-encapsulation
[Accessed 5 Nov 2022].
bing, 2022. bing.com. [Online] 
Available at: https://th.bing.com/th/id/OIP.J-IfpFW4MbMkHDxS7gKwCAHaEo?w=289&h=180&c=7&r=0&o=5&pid=1.7
[Accessed 2 Nov 2022].
Gray, D., 2021. HTML vs Body: How to Set Width and Height for Full Page Size. [Online] 
Available at: https://www.freecodecamp.org/news/html-page-width-height/
[Accessed 3 Nov 2022].
IBM App Connect, 2022. Creating a JSON message. [Online] 
Available at: https://www.ibm.com/docs/en/app-connect/11.0.0?topic=domain-creating-json-message
[Accessed 20 Sep 2022].
IIE, 2022. APDS7311 Lab Guide, Cape Town: IIE.
Krunal, 2022. Angular 13 Router Navigate: The Complete Guide. [Online] 
Available at: https://appdividend.com/2022/03/16/angular-router-navigate/#:~:text=To%20implement%20the%20navigation%20within%20the%20single%20page,URL%20as%20an%20instruction%20to%20change%20the%20view.
[Accessed 10 Nov 2022].
Krunal, 2022. Angular JWT Authentication: The Complete Guide. [Online] 
Available at: https://appdividend.com/2022/02/02/angular-authentication/
[Accessed 10 Nov 2022].
Love, C., 2021. 4 Ways to Use JavaScript to Redirect or Navigate to A URL or Refresh the Page. [Online] 
Available at: https://love2dev.com/blog/ways-to-use-javascript-redirect-to-another-page/#:~:text=4%20Ways%20to%20Use%20JavaScript%20to%20Redirect%20or,in%20a%20single%20page%20application%20...%20%C3%89l%C3%A9ments%20suppl%C3%A9mentaires
[Accessed 6 Nov 2022].
Mozilla, 2022. Regular expression syntax cheatsheet. [Online] 
Available at: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_Expressions/Cheatsheet#character_classes
[Accessed 5 Nov 2022].
pikwizard, 2022. pikwizard.com. [Online] 
Available at: https://pikwizard.com/photos/05c5d63d6037defd7f3048b4b73ea540-m.jpg
[Accessed 2 Nov 2022].
prezi, 2022. 0901.static.prezi.com. [Online] 
Available at: https://0901.static.prezi.com/preview/v2/osausgmjhb2jmj7pt3n6aq4nd76jc3sachvcdoaizecfr3dnitcq_3_0.png
[Accessed 2 Nov 2022].
shivamsingh00141, 2021. How to get Post Data in Node.js ?. [Online] 
Available at: https://www.geeksforgeeks.org/how-to-get-post-data-in-node-js/
[Accessed 21 Sep 2022].
taran910, 2020. How to enable routing and navigation between component pages in Angular 8 ?. [Online] 
Available at: https://www.geeksforgeeks.org/how-to-enable-routing-and-navigation-between-component-pages-in-angular-8/
[Accessed 10 Nov 2022].
W3Schools, 2022. CSS Examples. [Online] 
Available at: https://www.w3schools.com/css/css_examples.asp
[Accessed 4 Nov 2022].
W3Schools, 2022. CSS Buttons. [Online] 
Available at: https://www.w3schools.com/css/css3_buttons.asp
[Accessed 4 Nov 2022].
W3Schools, 2022. CSS Tutorial. [Online] 
Available at: https://www.w3schools.com/css/default.asp
[Accessed 4 Nov 2022].
W3Schools, 2022. HTML Elements. [Online] 
Available at: https://www.w3schools.com/html/html_elements.asp
[Accessed 4 Nov 2022].
W3Schools, 2022. HTML Links. [Online] 
Available at: https://www.w3schools.com/html/html_links.asp
[Accessed 4 Nov 2022].
wallpaperswide.com, 2022. chitrahandicraft.com. [Online] 
Available at: https://chitrahandicraft.com/wp-content/uploads/2019/02/login-page-background-images-hd-10.jpg
[Accessed 2 Nov 2022].

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.
To get more help on the backend section use `npm help` and the terminal should help the user further.
Should it be an unidentified issue within the application, feel free to contact the government IT department provided email and telephone number below.
Email: itdep001@nationalgov.co.za
Ph  : (021) 255 3691 
