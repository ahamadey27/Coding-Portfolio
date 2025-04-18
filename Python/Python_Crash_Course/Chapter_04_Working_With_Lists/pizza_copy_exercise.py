original_pizza = ['avacado', 'bacon', 'ham', 'turkey']
copy_pizza = original_pizza[:] #how to copy a list

original_pizza.append('bell pepper')
copy_pizza.append('mushroom')

print("My favorite pizzas are: ")
for orignal_pizzas in original_pizza[:]:
    print(orignal_pizzas.title())

print("\nMy friend's favorite pizzas are: ")
for copy_pizzas in copy_pizza[:]:
    print(copy_pizzas.title())
