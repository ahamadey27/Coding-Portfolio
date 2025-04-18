import random

rock = '''
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
'''

paper = '''
    _______
---'   ____)____
          ______)
          _______)
         _______)
---.__________)
'''

scissors = '''
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
'''

#Write your code below this line 👇
gameImages = [rock, paper, scissors]
1
userIndex = int(
    input("Please select rock, paper or scissors. Type 0 for rock, 1 for paper or 2 for scissors.\n"))
if userIndex >= 3 or userIndex < 0:
    print("Not a valid option. You Lose")
    exit()
userChoice = gameImages[userIndex]
print(f"You choose: {userChoice}")

computerChoice = random.choice(gameImages)
print(f"Computer chooses: {computerChoice}")

if userChoice == computerChoice:
    print("It's a tie!")
elif userChoice == 0 and computerChoice == 2:
    print("You Win!")
elif computerChoice == 0 and userChoice == 2:
    print("You losev :(")
elif computerChoice > userChoice:
    print("You lose :(")
elif userChoice > computerChoice:
    print("You Win!")
