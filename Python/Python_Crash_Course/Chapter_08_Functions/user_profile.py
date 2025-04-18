def build_profile(first, last, **user_info):
    """Build a dictionary using info from user"""
    user_info['first_name'] = first
    user_info['last_name'] = last
    return user_info

user_profile = build_profile('alex', 'hamadey',
    location = 'kingston',
    field = 'sound design'
)

print(user_profile)