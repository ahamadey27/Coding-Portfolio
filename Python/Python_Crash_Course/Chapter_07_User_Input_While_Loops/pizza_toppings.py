pizza_toppings = "Please enter your pizza toppings"
pizza_toppings += "\nEnter 'quit once you are finished: \n"


active = True
while active:
    selected_toppings = input(pizza_toppings)
    
    if selected_toppings == 'quit':
        active = False
    else:
        print(f"You have added {selected_toppings} to your pizza.")
    
