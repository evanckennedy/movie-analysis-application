# Movie Analysis Application

## Overview

This is a simple movie analysis application developed using ASP.NET MVC. The application allows users to perform various analyses on a collection of movies, actors, and ratings using LINQ. The data is stored in in-memory collections.

## Features

- View the complete list of movies.
- Filter movies by category.
- Get the count of movies in a specific category.
- Filter movies by budget.
- View movies released in the 1990s.
- Calculate the overall rating of a specific movie.

## Models

- **Actor**
  - ActorId (int): Represents the unique identifier of the actor.
  - Name (string): Represents the name of the actor.
  - Salary (decimal): Represents the salary of the actor.
- **Rating**
  - MovieId (int): Represents the unique identifier of the movie being rated.
  - Stars (int): Represents the rating stars (out of 5).
- **Movie**
  - MovieId (int): Represents the unique identifier of the movie.
  - Title (string): Represents the title of the movie.
  - Budget (decimal): Represents the budget of the movie.
  - ReleaseYear (int): Represents the year the movie was released.
  - Category (string): Represents the category/genre of the movie (e.g., 'Comedy', 'Action', 'Drama').
- **MovieActors**
  - MovieId (int): Represents the unique identifier of the movie.
  - ActorId (int): Represents the unique identifier of the actor who acted in the movie.

## Controllers

### MovieAnalysisController

- **Index**: Displays a list of all movies.
- **GetAllMoviesInCategory**: Filters movies by the specified category.
- **GetCountInCategory**: Returns the count of movies in the specified category.
- **MoviesInBudget**: Filters movies by the specified budget.
- **MoviesInThe90s**: Returns all movies released in the 1990s.
- **CalculateOverallRating**: Calculates the average rating of a specific movie.

## Views

- **Index**: Displays the complete list of movies.
- **GetAllMoviesInCategory**: Displays movies filtered by category.
- **MoviesInBudget**: Displays movies filtered by budget.
- **MoviesInThe90s**: Displays movies released in the 1990s.
- **CalculateOverallRating**: Displays the overall rating for the specified movie.

## Usage

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run the application.
4. Use the navigation links to access different functionalities.