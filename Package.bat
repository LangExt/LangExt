set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework\v4.0.30319
rmdir /S /Q bin

rmdir /S /Q LangExt.Compatibility.FSharp\obj
mkdir specify4.0
msbuild LangExt.Compatibility.FSharp\LangExt.Compatibility.FSharp.fsproj /p:DotNet=4.0;Configuration=Relaese;Platform=AnyCPU /t:Rebuild
rmdir specify4.0

nuget pack Package.nuspec
move *.nupkg bin\
