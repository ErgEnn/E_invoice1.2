dotnet clean

dotnet build --configuration release 

dotnet pack --configuration release --include-symbols --include-source -p:SymbolPackageFormat=snupkg -p:NuspecFile=E_invoice1.2.nuspec

nuget.exe push -Source https://api.nuget.org/v3/index.json E_invoice1.2/bin/Release/**.nupkg 

pause