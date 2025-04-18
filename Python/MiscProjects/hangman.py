# Collect the name of the creator.
Name = input('Please enter the name of the creator: ')
print('This game was made by ' + Name + '!')
print('In this program, you will try to guess a word that I chose.')

# Define the start function.
def start():
    # Collect the player's name.
    Player_Name = input('What is the name of the player? ')
    print('Greetings, ' + Player_Name + '! It is time to guess!')
    
    # The word that the player needs to guess (converted to lowercase).
    Secret_Word = 'Ostrich'.lower()
    
    # Initialize variables.
    Guesses = ''  # To store guessed letters.
    Turns_Left = 11  # Number of turns the player has.

    while Turns_Left > 0:
        Wrong_Answers = 0  # Initialize the count of wrong answers.

        # Loop through each letter in the secret word.
        for Letter in Secret_Word:
            if Letter in Guesses:
                # If the letter has been guessed, display it.
                print(Letter, end=' ')
            else:
                # If the letter has not been guessed, display an underscore.
                print('_', end=' ')
                Wrong_Answers += 1  # Increment the count of wrong answers.
        print()  # Print a newline after displaying the word.

        if Wrong_Answers == 0:
            # If there are no wrong answers left, the player wins.
            print('You Win! You guessed my word: ' + Secret_Word + '!!!')
            break

        # Collect the player's guess and add it to the list of guesses.
        Guess = input('Guess a letter here: ').lower()
        Guesses += Guess

        if Guess not in Secret_Word:
            # If the guess is not in the secret word, decrement the turns left.
            Turns_Left -= 1
            print('Oops! This letter is not in my word. Try again.')
            print('You have ' + str(Turns_Left) + ' more guesses left. You can do it!')
            if Turns_Left == 0:
                print('GAME OVER')

    # Define the Play_Again function.
    def Play_Again():
        # Ask if the player wants to play again.
        Again = input('Would you like to play again? ').lower()
        if Again == 'no':
            quit()
        elif Again == 'yes':
            # If the player wants to play again, call the start function.
            start()
        else:
            print('Please enter Yes or No.')
            Play_Again()

    # Call the Play_Again function to ask if the player wants to restart.
    Play_Again()

# Call the start function to start the game.
start()