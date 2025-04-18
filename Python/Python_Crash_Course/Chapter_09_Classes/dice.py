from random import randint
 
class Die:
    
    """Represents a dice that can be rolled"""
    def __init__(self, sides=6):
         self.sides = sides
         
    def roll_die(self):
        """returns a number between 1 and how many sides dice has"""
        return randint(1, self.sides)
    
# Six sided die
d6 = Die()

results = []
for roll_num in range(10):
    result = d6.roll_die()
    results.append(result)
    
print("Results of a 6 sided die: \n")
print(results)

#10 Sided Die
d10 = Die(sides=10)

results = []
for roll_num in range(10):
    result = d10.roll_die()
    results.append(result)
    
print("Results of a 10 sided die: \n")
print(results)

#20 Sided Die
d20 = Die(sides=20)

results = []
for roll_num in range(10):
    result = d20.roll_die()
    results.append(result)
    
print("Results of a 20 sided die: \n")
print(results)


