set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework\v4.0.30319
rmdir /S /Q bin

rmdir /S /Q LangExt.Compatibility.FSharp\obj
msbuild LangExt.Compatibility.FSharp.sln /t:Rebuild /p:Configuration=Release

.nuget\nuget pack Package.LangExt.Compatibility.FSharp.nuspec -Symbols
mkdir bin
move *.nupkg bin\
