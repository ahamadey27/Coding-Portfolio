from pathlib import Path
path = Path('Python_Crash_Course_Projects/Chapter_10_Files_And_Exceptions/guest_book.txt')

prompt = "\nHi, what's your name? "
prompt += "\nEnter 'quit' if you're the last guest. "

guest_names = []
while True:
    name = input(prompt)
    if name == 'quit':
        break
    
    print(f"\nThanks {name} we are adding you to the gust book")
    guest_names.append(name)
    
file_string = ''
for name in guest_names:
    file_string += f"{name}\n"

path.write_text(file_string.title())

