class Restaurant:
    def __init__(self, name, cusine_type):
        self.name = name.title()
        self.cusine_type = cusine_type.title()
        
    def descripe_restaurant(self):
        msg = f"{self.name} is a {self.cusine_type} restaurant"
        print(msg)
        
    def open_restaurant(self):
        msg = f"{self.name} is open for busness!"
        print(msg)
          
            
HammerFoods = Restaurant("hammer", "chinese")
HammerFoods.descripe_restaurant()

KillerEats = Restaurant("killer eats", "american")
KillerEats.descripe_restaurant()

SolidFoods = Restaurant("solif foods", "thai")
SolidFoods.descripe_restaurant()


            
            