Leaderboard ASP.Net API MVC to store Unity simple data: UserId, PlayerName, Points, and Date strucutre

- Visual Studio 2022

NuGet Dependencies:
- Microsoft.EntityFrameworkCore 8.06
- Microsoft.EntityFrameworkCore.Design 8.06
-  Microsoft.EntityFrameworkCore.Sqlite 8.06
-  Microsoft.VisualStudio.Web.CodeGeneration.Design 8.02

Step by Step terminal:
- dotnet new webapi -n LeaderboardAPI
- cd  LeaderboardAPI
- dotnet add package Microsoft.EntityFrameworkCore --version 7.0.0
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 7.0.0
- dotnet ef migrations add InitialCreate
- dotnet ef database update
- Add-Migration InitialCreate
