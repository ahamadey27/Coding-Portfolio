from pathlib import Path
import json

path = Path('Python_Crash_Course_Projects/Chapter_10_Files_And_Exceptions/fav_number_remembered.json')

try:
    contents = path.read_text()
    int_number = json.loads(contents)
    print(f"Your favorite number is {int_number}!")

except FileNotFoundError:
    number = input("whata's your favorite number: ")
    
    try: 
        int_number = int(number)
        path.write_text(json.dumps(int_number))
        print("number stored")
    except ValueError:
        print("please enter valid number")
