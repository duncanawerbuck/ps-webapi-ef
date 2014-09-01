# Web API 2, Entity Framework, MVC 5

As per Jesse Liberty's Pluralsight Course: "Building Web Apps & Services with Entity Framework and Web API"

## Technologies  
* Entity Framework (Code First approach)
* ASP.NET Web API 2 
* Breeze
* AngularJS (in particular, John Papa's Angular Hot Towel as a starting point)
* Boostrap
* jQuery

#### Three primary entities
* Books
* Orders
* OrderDetails

The README.md file is updated with relevant info, and should give a good idea of what's been done since previous check-in, as well as what's coming up next.

## Steps taken so far

1. Create an MVC 5 Web Application, of type Web API (this automatically includes the core libraries for MVC and Web API). Choose "No authentication" for now.
1. Create simple POCO for represent Book, Order and OrderDetail classes (note their navigation properties, which have the 'virtual' keyboard to 'help' Entity Framework).

## Next
* Create a controller - the main reason we're doing this is so the context class is created for us. The controller will be of type 'Web API 2 Controller with actions, using Entity Framework'.