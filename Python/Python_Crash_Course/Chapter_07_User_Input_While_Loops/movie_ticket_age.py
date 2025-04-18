prompt = "\nPlease enter your age to determine ticket price"
prompt += "\nPress 'quit' when finihsed\n"

while True:
    user_age = input(prompt)
    if user_age == 'quit':
        break
    user_age = int(user_age)
    
    if  user_age < 3:
        print("Free")
        
    elif user_age < 12:
        print("$10")
        
    else:
        print("$12") 