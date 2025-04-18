from pathlib import Path
path = Path('Python_Crash_Course_Projects/Chapter_10_Files_And_Exceptions/guest.txt')


name = input("\nWhat's your name? ")

path.write_text(name.title())
