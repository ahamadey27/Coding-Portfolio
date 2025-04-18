from random import choice

possibilities = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 'a', 'b', 'c', 'd', 'e']

winning_ticket = []
print("The winnnig numbers are... ")

while len(winning_ticket) < 4:
    pulled_items = choice(possibilities)
    
    if pulled_items not in winning_ticket:
        print(f"We pulled: {pulled_items}")
        winning_ticket.append(pulled_items)

print(f"\nThe final winning ticket is {winning_ticket}!")