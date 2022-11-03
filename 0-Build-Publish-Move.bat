dotnet restore

dotnet build --no-restore -c Release

move /Y Fancy.Schema\bin\Release\Fancy.Schema.*.nupkg D:\LocalSavoryNuget\

pause
