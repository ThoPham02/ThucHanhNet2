# Bài tập thực hành môn Lập trình .Net2 + BTL

- create dotnet app 
RUN: dotnet new mvc -o MVCProject

- run app
RUN: dotnet run

- install library
RUN: 
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

- migrations model
RUN: dotnet ef migrations add InitialCreate

- update database
RUN: dotnet ef database update

- 