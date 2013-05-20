ls *.markdown | %{ pandoc -s -o $($_.Name + '.html') --css=style.css $_.Name }
