2024-05-16
Yash Aggarwal
1730 UTC

 

Part 1
1730 UTC

Created a project name MVC Movies and added a controller

1745 UTC
Ran the program, Confirmed the default works:
https://localhost:7064/
Modified the index.cshtml title to MVC MOVIE by replacing the default title WELCOME
Created README.in the MVC Movies
Was able to confirm the default page

1810
I confirmed Part1 of the tutorial is complete, The started with part2

Part2 - Add a Controller

1830 UTC

Commented the default index method which is returning to class view()
Then added new index method and changed the content to "This is my default action..."
Was running when i ran the program

https://localhost:7064/Helloworld

1845  UTC
Added another method called welcome with the content of "This is the Welcome action method..."
Confirmed it was running

https://localhost:7064/Helloworld/welcome

1855 UTC

Change the Welcome method to include two parameters(name,numtimes)
Ran the program, Confirmed the changes works:

https://localhost:7064/helloworld/welcome?name=yash&numTimes=6


2024-05-23
Yash Aggarwal
1730 UTC

Part 3 
Worked on Add a View and edited the Views/Shared/_Layout.cshtml then edited the  HelloWorldController file present in controller and
ran the program, was able to see the local host was able to take the command where i gave the name yash and runtime 100 
and was able see my name in 100 lines respectively
https://localhost:7064/helloworld/welcome?name=yash&numTimes=6


Part 4 
1802 UTC
Started adding a model for which I created a file name movie.cs in models folder and in controller Scaffold movie pages.
and created a new item with the name moviescontroller.cs

1820
Migration was done 
20240523183621_initialCreate.cs

1825 UTC
Updated the database for the testing purpose

1850 UTC
Edited the movies name with title genre price and release date

1913 UTC

Testing and was successful 
https://localhost:7064/Movies



2024-05-30
Yash Aggarwal
1730 UTC

Started testing the oldder version

1750 UTC

Started with add a search 

1820 UTC

Worked on search  view/movies/Index.cshtml and edited the  MoviesController.cs Controller file present in controller and
ran the program, was able to see the local host was able to take the command where i gave the name yash and runtime 100 
and was able see my name in 100 lines respectively

1830 UTC

Migration Key 
20240530192027_Rating.cs

1850 UTC
Added the Rating in view/movies/create.cshtmlsl

