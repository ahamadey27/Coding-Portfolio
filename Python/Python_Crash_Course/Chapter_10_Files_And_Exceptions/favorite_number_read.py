from pathlib import Path
import json

path = Path('Python_Crash_Course_Projects/Chapter_10_Files_And_Exceptions/fav_numbers.json')

contents = path.read_text()
int_num  = json.loads(contents)

print(f"Your favorite number is {int_num}!")