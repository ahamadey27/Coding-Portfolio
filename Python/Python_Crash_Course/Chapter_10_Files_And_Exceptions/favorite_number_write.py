from pathlib import Path
import json

fav_number = input("Please give me your favorite number")
int_num = int(fav_number)

path = Path('Python_Crash_Course_Projects/Chapter_10_Files_And_Exceptions/fav_numbers.json')
contents = json.dumps(int_num )
path.write_text(contents)

print("I will store this number ")
