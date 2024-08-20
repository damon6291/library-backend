# Back-End

## How to run

Modify appsettings.json to have connectionString to your local Microsoft SQL database.
Run in visual studio. debug with Http for this example.
This will create 1000 book records and create db.

## Features

This has all features for auth and book. I made it dynamic as possible for further extensions.
ExpressionBuilder is not fully functioning. I only made the contain to work for this assignment purpose.
I am using Z.EntityFramework for bulk usages.
Background service is running every midnight to update the rental status.
I created interfaces for manager classes and services for easier mocking, testing, and updating.

## Improvements

I could add refresh token and make the JWT to expire more often to have a better security.
I could potentially add more indexes if needed.
For my DTOs I have it so that it works both ways, but to be explicit, I could break this into BookReturn and BookInput. This way, bookInput does not need to have fields like rented date, created date, etc.
I could add a separate project for testing. This will easily mock the interfaces and DBContext and test the core manager functions only.
It can be useful to add SignalR so the users get real time book inventory updates. However, in the real world, they should have the book in hand (unless they are making reservations or smth). This feature might not be necessary.
