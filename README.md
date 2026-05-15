# Library System
- Created by Matthew Cox

# Library Webpage App
A full-stack web app built with ASP.NET and Entity Framework Core. This projects simulates a modern library management system where users (borrowers) can: Browser available books, checkout/return books, View library events, and sign up for events. Admins (libraries) can manage books, users, loans, and events through role-based access controlls This was project was orginally written as a console-based C# program that was developed for a collgege class. Rebuilt as a complete web application with authentication, role-based access, and a persistent data base.

# How to run
Prerequisites
- .NET 8 SDK
- DB Browser for SQLite(This is optional, makes it easier to inspect the database)

Instalation

1. Clone the repository
git clone https://github.com/yourusername/LibrarySystem.git
cd LibrarySystem

2. Install Dependencies
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore

3. Apply database migrations
dotnet ef database update

4. Run the app
dotnet run

5. Open in Browser
http://localhost:5162

# Upcoming Features
- [ ] books page
- [ ] loans page
- [ ] Users page
- [ ] Account managment page
