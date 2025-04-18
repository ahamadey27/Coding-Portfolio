def make_car(manufacturer, model, **options):
    """Build a Dictionary about cars"""
    car_dict = {
        'manufacturer' : manufacturer.title(),
        'model' : model.title(),   
    }
    for option, value in options.items():
        car_dict[option] = value
        
    return car_dict

my_honda = make_car('honda', 'crv', color = 'blue', type = 'all wheel drive')
print(my_honda)