car = 'ford'
print("is car == 'ford'? I think true")
print(car == 'ford')

number1 = 15
number2 = 3 * 5
print(number1 == number2)

car2 = "BMW"
print(car2 == car2.lower())

banned_ingredients = {'corn', 'beef', 'hash'}
ingredient = 'corn'
if ingredient in banned_ingredients:
    print("stop")
else:
    print("go")
