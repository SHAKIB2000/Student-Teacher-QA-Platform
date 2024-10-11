# Student-Teacher Question & Answer Platform

A web-based application where students can ask study-related questions, and teachers can provide answers. The platform is inspired by StackOverflow and is built using ASP.NET Core 8.0, MSSQL, and follows Clean Architecture principles.

# Features
- **User Registration & Authentication:** Students and teachers can sign up, log in, and manage their accounts.
- **Student Dashboard:** View the latest questions and track personal Q&A.
- **Teacher Dashboard:** Browse and respond to student questions.
- **Question & Answer Management:** Students can ask questions, and teachers can provide answers. Questions can only be deleted if no answer exists.
- **Logging:** Integrated with Serilog for error and application tracking.

# Technologies Used
- **Language:** C#
- **Framework:** ASP.NET Core 8.0
- **Database:** MSSQL
- **ORM:** Entity Framework Core
- **Frontend:** jQuery, AJAX
- **Logging:** Serilog
- **Architecture:** Clean Architecture

# Database Schema
The project uses MSSQL for data storage, and the following tables are the core of the database.

**User Table**
- Id - Primary key, unique identifier.
- Name - Full name of the user.
- Email - Email address used for authentication.
- Password - Password for user authentication (hashed).
- Role - Role of the user (Student or Teacher).
- Institute - Name of the institute (required for students).
- InstituteId - Institute ID card number (required for students).

**Question Table**
- Id - Primary key, unique identifier.
- Title - Title of the question.
- Topic - Study topic related to the question.
- Content - Content of the question.
- PostedDate - Date the question was posted.
- StudentId - Foreign key, references the student (User).

**Answer Table**
- Id - Primary key, unique identifier.
- Content - Content of the answer.
- PostedDate - Date the answer was posted.
- TeacherId - Foreign key, references the teacher (User).
- QuestionId - Foreign key, references the question.

# Getting Started
**Prerequisites**
- .NET SDK 8.0
- SQL Server
- Visual Studio 2022 or any IDE supporting .NET development

**Installation**
1. Clone the repository: https://github.com/SHAKIB2000/Student-Teacher-QA-Platform.git

3. Update the MSSQL database connection in appsettings.json.

5. Apply database migrations: dotnet ef database update

7. Run the application.

# Logging
Logging is implemented using Serilog for error tracking and general application logs.

# Contributing
Contributions are welcome! Feel free to open a pull request or an issue.

# License
Distributed under the MIT License.
