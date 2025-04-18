from pathlib import Path

path = Path('Python_Crash_Course_Projects/Chapter_10_Files_And_Exceptions/pi_million_digits.txt')
contents = path.read_text()

lines = contents.splitlines()
pi_string = ''
for line in lines:
    pi_string += line.lstrip()
    
birthday = input("Enter your birthday: ")
if birthday in pi_string:
    print(f"Your birthday of {birthday} appears in pie")
else:
    print("Your bday does not appear in pi")