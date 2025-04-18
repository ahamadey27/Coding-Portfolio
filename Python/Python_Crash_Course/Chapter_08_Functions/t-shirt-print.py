def make_shirt(shirt_size, shirt_text):
    print(f"\nYour shirt size is {shirt_size} with the text {shirt_text}")
    
make_shirt('Medium', 'Text on a shirt')
make_shirt(shirt_text="My custom text on a tshirt", shirt_size="Large")

def make_shirt_2(shirt_size = 'Large', shirt_text = 'I Love Python'):
    print(f"\nYour shirt size is {shirt_size} with the text {shirt_text}")
make_shirt_2()
make_shirt_2(shirt_size='small', shirt_text='I Fell in Love with Python')