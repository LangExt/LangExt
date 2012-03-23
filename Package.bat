set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework\v4.0.30319
rmdir /S /Q bin

rmdir /S /Q LangExt\obj
mkdir specify4.0
powershell tools/t4.ps1
msbuild LangExt\LangExt.csproj /p:DotNet=4.0;Configuration=Relaese;Platform=AnyCPU /t:Rebuild
rmdir specify4.0

rmdir /S /Q LangExt\obj
mkdir specify3.5
powershell tools/t4.ps1
msbuild LangExt\LangExt.csproj /p:DotNet=3.5;Configuration=Relaese;Platform=AnyCPU /t:Rebuild
rmdir specify3.5

nuget pack Package.nuspec
move *.nupkg bin\
