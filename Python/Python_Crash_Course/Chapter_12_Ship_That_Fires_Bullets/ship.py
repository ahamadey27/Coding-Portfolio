import pygame

class Ship():
    """A class to manage the main character ship"""
    
    def __init__(self, ai_game): #ai_game = instance of the AlienInvasion class
        """initliaze shit and set its starting position"""
        self.screen = ai_game.screen
        self.screen_rect = ai_game.screen.get_rect()
        self.settings = ai_game.settings 
        
        #Load the ship image and get its react
        self.image = pygame.image.load('Python_Crash_Course_Projects\Chapter_12_Ship_That_Fires_Bullets\images\ship.bmp')
        self.rect = self.image.get_rect()
        
        #Start each new ship at the bottom center of the screen
        self.rect.midbottom = self.screen_rect.midbottom 
        
        #Store float for ship's exact horizontel settings
        self.x = float(self.rect.x)
        
        #Movement flag; start with a ship that's not moving
        self.moving_right = False
        self.moving_left = False
        
    def update(self):
        """Update ship position based on the movement flag"""
        #Update the ship's x value, not the rect
        if self.moving_right and self.rect.right < self.screen_rect.right:
            self.x += self.settings.ship_speed
        if self.moving_left and self.rect.left > 0:
            self.x -= self.settings.ship_speed
            
        #update rect object from self.x
        self.rect.x = self.x
        
    def blitme(self):
        """Draw the ship at its current location"""
        self.screen.blit(self.image, self.rect)