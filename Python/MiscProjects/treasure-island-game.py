
print("Welcome to Treasure Island.")
print("Your mission is to find the treasure.")

leftOrRight = input("Please type 'Left' or 'Right'\n").lower
if leftOrRight == "Right":
    print("Fall into a hole. Game over.\n")
else:
    swimOrWait = input("Swim or Wait\n").lower
    if swimOrWait == "Swim":
        print("Attacked by a trout. Game Over.\n")
    else:
        whichDoor = input(
            "Which door? Blue? Red? Yellow? Any other color\n").lower
        if whichDoor == "Red":
            print("Burnt by fire. Game over.\n")
        if whichDoor == "Blue":
            print("Eaten by beasts. Game over.\n")
        if whichDoor == "Yellow":
            print("You win!")
        else:
            print("Game Over\n")
