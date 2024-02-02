# this prints values 1 - 10 to the power of three
cubed = []
for cubedValue in range(1, 11):
    cube = cubedValue ** 3
    cubed.append(cube)
    
print(cubed)

# cubed values of 1 through 10 but suing the list comprehension method
cubed = [cubedValue ** 3 for cubedValue in range (1, 11)]
print(cubed)