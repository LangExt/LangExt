set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework\v4.0.30319
rmdir /S /Q bin

rmdir /S /Q LangExt.Legacy\obj
msbuild LangExt.Legacy.sln /t:Rebuild /p:Configuration=Release

.nuget\nuget pack Package.LangExt.Legacy.nuspec -Symbols
mkdir bin
move *.nupkg bin\
