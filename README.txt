Started project on 2023/10/10 at 2:30 pm.
Started with creating a README text file.
Commented the line with port number and started without debugging and i got my application opened!!!
Added a controller in the controllers folder and edited the code.
Appended "HelloWorld" to the path in the address bar. The Index method returned a string.
After that i exmined my welcome method and the ouput is okay.
After that i changed the welcome method to include parameters.
Then, i changed the index method in the "HelloWorldController" class.
Then, added a anew folder in views folder and named it Hello World. Added a new item in this folder and named it Index.cshtml.
After that, i changed the title, footer, and menu link in the file "_Layout.cshtml".
After completing there steps, i continued to change the Index.cshtml.
In that file, changed the title and h2 element.
Changed the he element to My Lamps List.
Now,i edited the home/index.cshtml page to change the browser title, primary heading and secondary headings.
Then, i passed ViewData dictionary object that contains data to the view.
After that, i created a new item in HelloWorld folder which i named "Welcome.cshtml" to create a loop in that item.
Added a new class in the Models folder which is named as GurmanLamp.cs and then, added a Primary key "Id" and properties like type, Price, Manufacturing Time Material used, BulbColor and LampColor.

2023/10/11 at 11:30 am
Added NuGet Package.
Then, created Data folder and added a file in it "GurmanLampContext.cs" to create a DbSet<GurmanLamp> property for entity set.
After completing that, added statements at the top of the startup.cs file : "using GurmanLampContext.Data;
using Microsoft.EntityFrameworkCore;".
Then, i went through the code of file "Startup.ConfigureServices" and did changes in the code.The name of the connection string is passed in to the context by calling a method on a DbContextOptions object.
Then i examined database connection string.
To do so, opened the appsettings.json file and build the project to check for compiler errors.
After cleaning and rebuilding the solution, i did scaffolding.
Then, i tried to add migration and it was successful attempt.
Now, i started to add image and designing the app.
Added about.cshtml file.
I seeded data.







