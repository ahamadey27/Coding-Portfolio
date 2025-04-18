rivers = {
    'nile': 'egypt', 
    'amazon': 'brazil', 
    'yellow': 'china',}

for river, country in rivers.items():
    print(f"The {river.title()} runs through {country.title()}.")
    
#Prints just the key
for river in rivers.keys(): 
    print(river.title())
    
#Prints just the value
for country in rivers.values():
    print(country.title())