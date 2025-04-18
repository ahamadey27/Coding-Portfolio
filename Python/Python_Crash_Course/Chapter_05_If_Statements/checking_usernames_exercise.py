current_users = ['bill', 'frank', 'sam', 'ryan', 'tom']
new_users = ['sara', 'jane', 'sam', 'frank', 'tilda']
for new_user in new_users:
    if new_user in current_users:
        print(f"Sorry, {new_user} is already")
    else:
        print(f"Welcome {new_user} to website")