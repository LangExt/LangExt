git clean -dfx
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
rmdir -Recurse -Force doc
git add -A
git commit --no-verify -m "update document."
