class Restaurant:
    def __init__(self, name, cusine_type):
        self.name = name.title()
        self.cusine_type = cusine_type
        
    def descripe_restaurant(self):
        msg = f"{self.name} is a {self.cusine_type} restaurant"
        print(msg)
        
    def open_restaurant(self):
        msg = f"{self.name} is open for busness!"
        print(msg)
          
            
restaurant = Restaurant("hammer", "chinese")
print(restaurant.name)
print(restaurant.cusine_type)

restaurant.descripe_restaurant()
restaurant.open_restaurant()
            
            