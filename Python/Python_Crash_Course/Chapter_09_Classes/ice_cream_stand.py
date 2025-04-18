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

class IceCreamStand(Restaurant): 
    def __init__(self, name, cusine_type='ice cream'):
        super().__init__(name, cusine_type)
        self.flavors = []
        
    def ShowFlavors(self): 
        """Display available Flavors"""
        print("\nWe have the following flavors:\n")
        for flavor in self.flavors:
            print(f"- {flavor.title()}")
    
hammer_ice = IceCreamStand("Hammer's Ice Cream")
hammer_ice.flavors = ['chocolate', 'vanilla', 'beer']

hammer_ice.descripe_restaurant()
hammer_ice.ShowFlavors()

    