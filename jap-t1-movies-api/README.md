# JAP-T1-MOVIES-API

This is the backend repository for a movie rating app similair to IMDB or TMDB but much simpler. TEchnology used for backend development is .NET 5.

## Setup instructions
1. Clone this repository to your local machine
2. Make sure you have SQL Server set up. If you own a database with the name **Task1MoviesApp** then make sure to change the name of this project's databse by going to **appsettings.Development.json** and changing the **ConnectionStrings'** **DefaultConnection** value.
3. run `dotnet ef database update` in the terminal to create the database
4. run `dotnet watch run` to start the web api

## Functionalities

- REST API
- Routes for searching movies and tv shows, getting all movies/tv shows from the database, rating movies and user register and login.
