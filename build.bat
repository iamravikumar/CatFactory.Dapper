cls
set initialPath=%cd%
set srcPath=%cd%\CatFactory.Dapper\CatFactory.Dapper
set testPath=%cd%\CatFactory.Dapper\CatFactory.Dapper.Tests
cd %srcPath%
dotnet build
cd %testPath%
dotnet test
cd %srcPath%
dotnet pack
cd %initialPath%
pause
