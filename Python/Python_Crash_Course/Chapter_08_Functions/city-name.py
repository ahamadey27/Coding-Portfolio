def city_name(city, country):
    """Return city name and country"""
    full_name = f"{city}, {country}"
    return full_name.title()

city_country_name = city_name('saniago', 'chile')
print(city_country_name)

city_country_name = city_name('new york', 'united states')
print(city_country_name)

city_country_name = city_name('paris', 'france')
print(city_country_name)
