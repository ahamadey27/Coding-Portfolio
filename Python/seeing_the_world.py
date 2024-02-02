cities = ["tokyo", "helsinki", "santiago", "seol", "zealand"]
print(cities)

#just prints list alphabetically (non-destructively)
print(sorted(cities))

#just prints list reverse alphabetically (non-destructively)
cities.reverse()
print(cities)

cities.reverse()
print(cities)

#stores list alphabetically
cities.sort()
print(cities)

#stores list reverse alphabetically
cities.sort(reverse=True)
print(cities)
