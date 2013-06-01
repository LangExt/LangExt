$crntBranch = git symbolic-ref HEAD
if ($crntBranch -ne 'refs/heads/master') {
  echo 'please checkout master.'
  exit 1
}

$cleanTargets = git clean -dnx
if (-not [string]::IsNullOrEmpty($cleanTargets)) {
  echo 'please clean workspace.'
  echo $cleanTargets
  exit 1
}

$id = git rev-parse master
mkdir tmp
cd doc
.\gendoc.ps1
copy *.html ..\tmp
copy *.css ..\tmp
cd ..
git checkout gh-pages
rm *.html
rm *.css
mv tmp\* .
rmdir tmp
rmdir -Recurse -Force doc
git add -A
git commit --no-verify -m "update document.`n`nid: $id"
