print("Welcome to the tip calculator.")
bill = float(input("What is your total bill?\n"))
tip = int(input("How much would you like to tip? 10, 12, or 15?\n"))
people = int(input("How many people are splitting the bill?\n"))

tipAsPercent = tip / 100
totalTipAmount = bill + tipAsPercent
totalBill = bill + totalTipAmount
billPerPerson = totalBill / people
finalAmount = round(billPerPerson, 2)

print(f"Each person pays: {finalAmount}")
