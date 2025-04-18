cities = {
    'austin': {
        'country': 'usa',
        'population': 132435,
        'fact': 'lots of bbq',
    },
    
    'berlin': {
        'country': 'germany',
        'population': 12566542,
        'fact': 'lots of techno',
    },
    
    'paris': {
        'country': 'france',
        'population': 865426,
        'fact': 'lots of baquettes',
    },
}

for city, country_info in cities.items():
    print(f"\nCity: {city.title()}")
    country_name = country_info['country']
    population_info = country_info['population']
    fact_info = country_info['fact']
    
    print(f"\tCountry: {country_name.title()}")
    print(f"\tPopulation: {population_info}")
    print(f"\tFact: {fact_info.title()}")