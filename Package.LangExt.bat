set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework\v4.0.30319
rmdir /S /Q bin

rmdir /S /Q LangExt\obj
msbuild LangExt.sln /t:Rebuild /p:Configuration=Release

.nuget\nuget pack Package.LangExt.nuspec -Symbols
mkdir bin
move *.nupkg bin\
