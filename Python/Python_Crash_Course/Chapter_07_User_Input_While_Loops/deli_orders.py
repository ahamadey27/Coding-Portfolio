orders = ['grilled cheese', 'ham', 'turkey', 'tuna']
finihsed_orders = []

while orders:
    current_order = orders.pop()
    print(f"I'm working on {current_order}")
    finihsed_orders.append(current_order)

print("\nThe following sandwiches are done:")
for current_order in finihsed_orders:
    print(current_order.title())