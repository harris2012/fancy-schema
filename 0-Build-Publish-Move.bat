dotnet restore

dotnet build --no-restore -c Release

move /Y Fancy.Schema\bin\Release\Fancy.Schema.*.nupkg D:\LocalSavoryNuget\
move /Y Fancy.Schema.Extension\bin\Release\Fancy.Schema.Extension.*.nupkg D:\LocalSavoryNuget\

pause
