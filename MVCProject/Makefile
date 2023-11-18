gen-migrations:
	dotnet ef migrations add Create_table_Employee
update-db:
	dotnet ef database update
gen-controller-view:
	dotnet aspnet-codegenerator controller -name EmployeeController -m Employee -dc MVCProject.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
