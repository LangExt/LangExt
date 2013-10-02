$myDir = [System.IO.Path]::GetDirectoryName($MyInvocation.MyCommand.Path)
$projectRoot = [System.IO.Path]::GetDirectoryName($myDir)
$packageDir = [System.IO.Path]::Combine($projectRoot, 'nuget-packages')
 
$orgPath = $(pwd).Path
cd $projectRoot

$nuget = 'NuGet.exe'
try {
  NuGet.exe help > $nul
} catch [Exception] {
  $nuget = [System.IO.Path]::Combine($projectRoot, '.nuget', 'NuGet.exe')
}

# TODO : edit versions
 
$asmInfoPath = [System.IO.Path]::Combine($projectRoot, 'LangExt', 'Properties', 'AssemblyInfo.cs')
$(cat $asmInfoPath | ?{ $_.StartsWith('[assembly: AssemblyVersion(') }) -match 'AssemblyVersion\("([^)]+)"\)'
$asmVer = $Matches[1]
$version = $asmVer -replace "(.0){0,2}$"
$tagName = "v$version"
 
$preMaster = git rev-parse master
 
git commit -am $version
git tag $tagName
 
git checkout master
git reset --hard $tagName
git clean -dfx
 
&$myDir\New-Package.ps1
if (-not $?) {
  git tag -d $tagName
  git reset --hard $preMaster
  git checkout $version
  git reset --hard HEAD^
  cd $orgPath
  exit 1
}
 
git branch -D $version

cd $packageDir
ls -Exclude *.symbols.nupkg | %{
  &$nuget push $_.Name
}

cd $projectRoot

git push origin master
git push origin $tagName

git clean -dfx
&$myDir\New-GithubPagesCommit.ps1 "update document(for $version)."
git push origin gh-pages
git checkout master
git clean -dfx

cd $orgPath
trap { cd $orgPath }
