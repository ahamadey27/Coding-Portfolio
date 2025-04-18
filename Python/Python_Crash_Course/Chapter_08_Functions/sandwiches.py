def user_toppings(*toppings):
    print("Your order is ready with the following toppings:")
    for topping in toppings:
        print(f"- {topping}")
    


user_toppings("cheese", "bacon", "turkey")
user_toppings("tomato", "chicken", "turkey")
user_toppings("pepper", "bacon", "gravey")


    

