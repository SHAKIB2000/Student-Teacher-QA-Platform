# Student-Teacher Question & Answer Platform

A web-based application where students can ask study-related questions, and teachers can provide answers. The platform is inspired by StackOverflow and is built using ASP.NET Core 8.0, MSSQL, and follows Clean Architecture principles.

# Features
User Registration & Authentication: Students and teachers can sign up, log in, and manage their accounts.
Student Dashboard: View the latest questions and track personal Q&A.
Teacher Dashboard: Browse and respond to student questions.
Question & Answer Management: Students can ask questions, and teachers can provide answers. Questions can only be deleted if no answer exists.
Logging: Integrated with Serilog for error and application tracking.

# Technologies Used
Language: C#
Framework: ASP.NET Core 8.0
Database: MSSQL
ORM: Entity Framework Core
Frontend: jQuery, AJAX
Logging: Serilog
Architecture: Clean Architecture (N-Layered)
Database Schema
The project uses MSSQL for data storage, and the following tables are the core of the database.

User Table
Column	Type	Description
Id	GUID	Primary key, unique identifier.
Name	string	Full name of the user.
Email	string	Email address used for authentication.
Password	string	Password for user authentication (hashed).
Role	string	Role of the user (Student or Teacher).
Institute	string	Name of the institute (required for students).
InstituteId	string	Institute ID card number (required for students).

Question Table
Column	Type	Description
Id	GUID	Primary key, unique identifier.
Title	string	Title of the question.
Topic	string	Study topic related to the question.
Content	string	Content of the question.
PostedDate	DateTime	Date the question was posted.
StudentId	GUID	Foreign key, references the student (User).
Answer Table
Column	Type	Description
Id	GUID	Primary key, unique identifier.
Content	string	Content of the answer.
PostedDate	DateTime	Date the answer was posted.
TeacherId	GUID	Foreign key, references the teacher (User).
QuestionId	GUID	Foreign key, references the question.
Getting Started
Prerequisites
.NET SDK 8.0
SQL Server
Visual Studio 2022 or any IDE supporting .NET development
Installation
Clone the repository:

Update the MSSQL database connection in appsettings.json.

Apply database migrations:

dotnet ef database update
Run the application:

# Logging
Logging is implemented using Serilog for error tracking and general application logs.

# Contributing
Contributions are welcome! Feel free to open a pull request or an issue.

# License
Distributed under the MIT License.