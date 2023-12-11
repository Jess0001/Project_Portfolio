#Study Planner
***
A windows platform foundation application using the C# language to create a theoretically accurate study schedule for students.

##Tables of Contents
1.	[Project Status]
2.	[Requirements]
3.	[Collaboration]
4.	[Upcoming improvements]
5.	[Sources]

###Project Status
***
Currently still under development...

###Requirements
***
Visual Studio 2019 Standard version will be preferably required to test the prototype.

###Collaboration
***
•	Click on the button labelled “Study Planner” to start running the application.
•	The application will show a warning to alert the user of the terms they have to agree to continue using the application.
	o	Click on “terms and conditions” to read the terms.
	o	Click on the radio button to agree to terms.
	o	Once radio button is checked click “Next”.
	o	If user disagrees to terms, he/she may exit.
•	Click “Begin” to start planning weekly study schedule.
•	The application will require the user to enter values according to what is prompted within the set dialog.
	o	Select date for start of the semester.
			The application will prompt the user to select a starting semester date.
			Starting date shouldn’t be null.
			User selects start date.
	o	Select date for end of the semester.
			The application will prompt the user to select an ending semester date.
			Ending date shouldn’t be null.
			User selects end date.
	o	Enter number of weeks for semester.
			The application will prompt the user to enter the number of semester weeks.
			Number of weeks cannot be negative for application to proceed.
			User enters number of weeks.
•	Click “Next” to continue.
•	The application will require the user to enter furthermore values according to what is prompted within the set dialog.
	o	Enter Module code.
			The application will prompt the user to enter the module code.
			Module code should preferably be 8 characters.
			Module code shouldn’t be null.
			User enters module code.
	o	Enter Module name.
			The application will prompt the user to enter the module name.
			Module name should preferably be less than or equal to 120 characters.
			Module name shouldn’t be null.
			User enters module name.
	o	Enter number of credits.
			The application will prompt the user to enter the number of credits.
			Number of credits cannot be negative for application to proceed.
			User enters number of credits.
	o	Enter number of weekly class hours.
			The application will prompt the user to enter the number of weekly class hours.
			Number of weekly class hours cannot be negative for application to proceed.
			User enters weekly class hours.
•	Click “Next” to continue.
•	The application will require the user to enter furthermore values according to what is prompted within the set dialog.
	o	Enter number of finished study hours for module.
			The application will prompt the user to enter the number of complete studied hours.
			Number of complete studied hours cannot be negative for application to proceed.
			User enters complete studied hours.
	o	Select date for when the user completed those study hours.
			The application will prompt the user to select a study date.
			Study date shouldn’t be null.
			User selects study date.
•	Click “Next” to continue.
•	The application will then show a message asking if the user would like to add another module.
	o	Click “Yes” to add another module.
			Refer to the sixth main bullet when adding another module.
	o	Click “No” to stop adding modules.
•	Once user is complete adding modules, the application calculates the weekly study schedule.
•	User views the weekly study schedule.
•	To finish running the application, the user clicks “Exit” to exit.

###Upcoming Improvements
1. Data storage making use of a SQL database. 
2. Account registration, including a username and password (storing only the hash of the password).
3. Login user accounts using a username and password.
4. Improved privacy of each user’s data.

###Sources
Background pictures:
•	https://st3.depositphotos.com/7145424/i/600/depositphotos_362652944-stock-photo-many-stacks-books-study-university.jpg
•	https://p0.pikist.com/photos/790/249/background-copy-space-texture-blue-concept-activity-student-study-learning.jpg 
•	https://data.whicdn.com/images/298744872/original.jpg
•	https://i.pinimg.com/originals/78/7b/e0/787be06e07db8c0721fac19633de40cc.jpg
Coding and research references:
•	Caillen, 2015. convert a Text Box To string. [Online] 
Available at: https://social.msdn.microsoft.com/Forums/vstudio/en-US/3f98809b-77f5-469b-ac93-23b7f5099f92/convert-a-text-box-to-string?forum=csharpgeneral
[Accessed 16 Sep 2021].
•	Microsoft, 2017. Custom date and time format strings. [Online] 
Available at: https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
[Accessed 11 Sep 2021].
•	Microsoft, 2021. DatePicker.BlackoutDates Property. [Online] 
Available at: https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.datepicker.blackoutdates?view=net-5.0
[Accessed 11 Sep 2021].
•	Microsoft, 2021. DateTime.Compare(DateTime, DateTime) Method. [Online] 
Available at: https://docs.microsoft.com/en-us/dotnet/api/system.datetime.compare?view=net-5.0
[Accessed 9 Sep 2021].
•	Microsoft, 2021. DateTime.Date Property. [Online] 
Available at: https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-5.0
[Accessed 9 Sep 2021].
•	Microsoft, 2021. DateTime.ToString Method. [Online] 
Available at: https://docs.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-5.0
[Accessed 9 Sep 2021].
•	Microsoft, 2021. Format a date and time field. [Online] 
Available at: https://support.microsoft.com/en-us/office/format-a-date-and-time-field-47fbbdc1-52fa-416a-b8d5-ba24d881b698
[Accessed 16 Sep 2021].
•	Microsoft, 2021. ScrollViewer Class. [Online] 
Available at: https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.scrollviewer?view=net-5.0
[Accessed 17 Sep 2021].
•	Microsoft, 2021. SortedSet<T> Class. [Online] 
Available at: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.sortedset-1?view=net-5.0
[Accessed 16 Sep 2021].
•	Microsoft, 2021. Tutorial: Create a .NET class library using Visual Studio. [Online] 
Available at: https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-5-0
[Accessed 9 Sep 2021].
•	Oxford, 2021. Lexico. [Online] 
Available at: https://www.lexico.com/
[Accessed 15 Sep 2021].
•	Rebori, K., 2019. 8 Paint Colors For A Learning Environment. [Online] 
Available at: https://www.paintzen.com/blog/8-paint-colors-for-learning
[Accessed 15 Sep 2021].
•	Troelsen, A. & Japikse, P., 2017. Pro C# 7 With .NET and .NET Core. 8th ed. CA: Apress Media.
