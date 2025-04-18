class Users: 
    """Storing user info"""
    
    def __init__(self, first_name, last_name, age, email, zip_code):
        self.first_name = first_name.title()
        self.last_name = last_name.title()
        self.email = email
        self.zip_code = zip_code
        self.age = age
        self.login_attempts = 0
    
    def describe_user(self): 
        """Prints summary of user info"""
        msg = f"{self.first_name} {self.last_name} is {self.age} years old at {self.email} residing in the area of {self.zip_code}"
        print(msg)
        
    def greet_user(self):
        """Greets user"""
        msg = f"Hello, {self.first_name} {self.last_name}!"
        print(msg)
        
    def increment_login_attempts(self):
        """Increments ligin attempts by 1"""
        self.login_attempts += 1
    
    def reset_login_attempts(self):
        """Resets login attempts to zero"""
        self.login_attempts = 0
        
        
    
user_01 = Users("alex", "hamadey", 38, "hamadey@gmail.com", 12401)
user_01.describe_user()
user_01.greet_user()

user_02 = Users("bill", "samson", 48, "bill.samson@gmail.com", 19801)
user_02.describe_user()
user_02.greet_user()

print("\nMaking 3 login attempts")
user_01.increment_login_attempts()
user_01.increment_login_attempts()
user_01.increment_login_attempts()
print(f"{user_01.first_name} attempted to login {user_01.login_attempts} times")

user_01.reset_login_attempts()
print(f"\n{user_01.first_name} login attempts have been set back to {user_01.login_attempts}.")