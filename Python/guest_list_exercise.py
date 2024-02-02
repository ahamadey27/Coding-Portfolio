dinnerGuests = ["Jesus", "Carment Electra", "Pol Pot"]
print(f"{dinnerGuests[0]}, please be undead and join us.")
print(f"{dinnerGuests[1]}, please ditch Dennis Rodman and join us.")
print(f"{dinnerGuests[2]}, I know you're burning in hell, but please join us for dessert at least.")

print(f"{dinnerGuests[0]} and {dinnerGuests[2]} cannot make it to dinner")

#replaces index in list
dinnerGuests[0] = "Pit the Elder"
dinnerGuests[2] = "Lord Palmerston"

print(f"{dinnerGuests[0]}, please be undead and join us.")
print(f"{dinnerGuests[1]}, please ditch Dennis Rodman and join us.")
print(f"{dinnerGuests[2]}, I know you're burning in hell, but please join us for dessert at least.")

print("There is more room for more guests")

#add guest to beggining, middle and end of list
dinnerGuests.insert(0, 'Sammy Davis Jr Jr') 
dinnerGuests.insert(2, 'Sammy Davis Jr')
dinnerGuests.append('Dirk Diggler')

#easist way to print each name in list
for dinnerGuest in dinnerGuests:
    print(f"Hello, {dinnerGuest}! Please join us for dinner!")
    
#.pop() removes and stores the last element of list 
deletedGuest = dinnerGuests.pop() 
print(deletedGuest + " sorry you're not on the list")

deletedGuest = dinnerGuests.pop() 
print(deletedGuest + " sorry you're not on the list")

deletedGuest = dinnerGuests.pop() 
print(deletedGuest + " sorry you're not on the list")

deletedGuest = dinnerGuests.pop() 
print(deletedGuest + " sorry you're not on the list")

print(f"{dinnerGuests[0]} and {dinnerGuests[1]} you two are good to go")

print(dinnerGuests)

#length of a list
print(len(dinnerGuests))