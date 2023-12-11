# DiabetesGuide
#GigaCo

READ ME

---------------------
CONTENTS OF THIS FILE
---------------------

 * Introduction
 * Requirements
 * APIs & Plug-Ins
 * Installation
 * How to Use
 * Files
 * Bugs
 * Future Updates
 * References

---------------------
Introduction
---------------------

Diabetes Guide is an Lifestyle Management application built on Android Studio that will helps the user manage their or a
diabetic patient's lifestyle more efficiently as well as providing information on the condition.

The application is built using Java and XML.

---------------------
Requirements
---------------------

The user is required to initially have Android Studio and an emulator that projects the application when ran. However
when testing becomes successful the application can be provided within an apk and available on Google PlayStore

---------------------
APIs & Plug-Ins
---------------------

API 23

---------------------
Installation
---------------------

Download the DiabetesGuide folder. Open the project using Android Studio.

---------------------
How to Use
---------------------

1.  Download the 'DiabetesGuide' folder on the pc.
2.  Open AndroidStudio.
	- If the user is using Bluestacks, the bluestacks will need to be connected to the emulator before
	  opening AndroidStudio.
3.  Go to the file tab in android studio, select 'open file' and select the 'DiabetesGuide' project, it will
    be located in the 'DiabetesGuide' folder.
4.  Sync Gradle in project.
5.  In android studio, once the run icon turns green, click it and the application will run on the emulator.
	- It may take a while for the emulator to start the application, especially if it's the first time.
6.  The Diabetes SA logo appears and the application loads before it navigates to the Login page.
7.  First time users will need to got to the sign-up page via the provided create account link or join tab on
    the login page.
	-Once account is created, the application will redirect to the login page.
8.  The application will open on the Home page.
9.  The user can select which section they would like to navigate provided the icons and descriptions.
10. Users can go to their profile information and change their name, password and email address.
11. If user experiences any errors while using Cape Guide, please refer to the troubleshoot section of
    the READ ME.
    - Should the issue not be resolved, redirect to the contact page and reach out to use with the details
      provided
12. Once done, user can exit the application.

---------------------
Files
---------------------

Adapters:
1. TabLayoutAdapter

Fragments:
1. LoginFragment
2. RegisterFragment

Permissions:
1. AppPermissions

WebServices:
1.  Login
2.  MainActivity
3.  Register

layout:
1.  activity_main.xml
2.  activity_login.xml
3.  activity_login_fragment.xml
4.  activity_login_page.xml
5.  activity_register_page.xml
6.  activity_register_fragment.xml
7.  account.xml
8.  activity_book_doctor.xml
9.  activity_calendar.xml
10. activity_contact.xml
11. activity_contact_form.xml
12. activity_create_logs.xml
13. activity_login_register_tabs.xml
14. home.xml
15. activity_reccomendations.xml
16. activity_reminders.xml
17. activity_splash_screen.xml
18. activity_stats.xml
19. activity_tips_tricks.xml
20. activity_user_profile.xml

value:
1. colors.xml
2. strings.xml
3. styles.xml

---------------------
Trouble Shooting & Bugs
---------------------

Input errors:
1.  Ensure that the spelling is correct when adding information to the app.
2.  Ensure login details are correct.
3.  Ensure you have created an account before attempting to log into the application for the first time.
4.  If bookmarks do not show, try exiting the application (stop run time) and run the app again.
5.  Ensure device is connected to an uninterrupted  internet source.

Navigation errors:
1.  Restart the applications.
	- If restarting the app does not work, restart Android Studio and reconnect the emulator.
2.  Ensure all spelling is correct if the page requires any input.
3.  Ensure all information required is uploaded.
4.  Ensure the correct icon is being used for the function attempting to be used.
5.  If the user cannot return to the previous page via the application icons, make use of the emulator
    devices back button.
6. In Android Studio, go to the build tab and select rebuild and then try starting the application again.

Start-up errors:
1.  Try rebooting pc.
2.  Try restarting the application.
	-If restarting the app does not work, restart Android Studio.
3.  Ensure the Diabetes Guide project was extracted completely and correctly.
4.  In Android Studio, select build tab and select rebuild and then try starting the application again.
5.  Ensure internet connection.
6.  Ensure the correct version and packages of android studio are installed.
7.  Ensure pc meets the requirements listed at the start of the READ ME.
8.  Ensure emulator is correctly connected and setup.
9.  Try re-syncing the gradle.
10. Try rebuilding project.

---------------------
Future Updates
---------------------

1. We aim to fix to bugs for a smoother functioning system.
2. We hope to fix our login/register tab transition for ease of creating user accounts and logging
   in.
3. Improve functionality within system.
4. Improve user design within system based on feedback and guidance with DiabetesSA
5. We aim to get the application working as soon as possible.

---------------------
References
---------------------

References used for building Diabetes Guide:
1. https://console.cloud.google.com/google/maps-apis/credentials?project=opsc7312-project
