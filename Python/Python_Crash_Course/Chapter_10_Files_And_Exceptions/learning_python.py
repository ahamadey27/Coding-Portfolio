from pathlib import Path
path = Path('Python_Crash_Course_Projects/Chapter_10_Files_And_Exceptions/learning_python.txt')

contents = path.read_text()
print(contents)

lines = contents.splitlines()
for line in lines:
    print(line)
    
new_lines = contents
for new_line in lines:
    print(new_line.replace('Python', 'C++'))