nameList = ["hammer", "bill", "ryan", "sam"]
nameList = nameList
print(nameList[0])
print(nameList[1])
print(nameList[2])
print(nameList[3])

print(nameList[0].upper() + " you are a great dude\n" + nameList[1].title() + " is also sold.\n" + nameList[2].title() + " has lots of rzz.\n")

#use the f-string with {} for lists...this will pring the same as the code above
print(f"{nameList[0].upper()} you are a great dude\n{nameList[1].title()} is also sold.\n{nameList[2].title()} has lots of rzz.\n")

print(nameList[-1].title() + " is the last name in this list")