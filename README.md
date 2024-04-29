## Created as a solution for a technical test

To run the project, run the following at the solution directory:
```powershell
  dotnet build
```
The project has two ways to run, if you run it with a param, it will try to read the param and return the results:
```powershell
dotnet run --project RiskAssessment.Presentation '[ {\"Value\": 2000000, \"ClientSector\": \"Private\"}, {\"Value\": 400000, \"ClientSector\": \"Public\"}, {\"Value\": 500000, \"ClientSector\": \"Public\"}, {\"Value\": 3000000, \"ClientSector\": \"Public\"} ]'
```
Or will ask for you to manually include each value if you don't provide a param:
```powershell
dotnet run --project RiskAssessment.Presentation
```
The project has been created respecting DDD, SOLID and some principles of the clean architecture.

The solution for the SQL part of the test is present at the `SQL` folder, divided in three parts, `Table Modeling`, `Procedure Creation` and `Procedure Execution`
