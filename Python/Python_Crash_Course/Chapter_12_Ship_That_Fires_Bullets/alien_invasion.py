import sys
import pygame

from settings import Settings
from ship import Ship

class AlienInvasion: 
    """Overall class to manage game assets and behaviors"""
    
    def __init__(self):
        """Initiliaze game and create game resources"""
        pygame.init() #initializes background settings that pygame needs to work
        self.clock = pygame.time.Clock() #creates clock for franme rate
        self.settings = Settings() #create instanse of the settings class  
        
        self.screen = pygame.display.set_mode((0, 0), pygame.FULLSCREEN) 
        self.settings.screen_width = self.screen.get_rect().width
        self.settings.screen_height = self.screen.get_rect().height
        #self.screen is a surface where game elements can be displayed and pygame.display.set_mode is entire game window
        pygame.display.set_caption('Alien Invasion')
        self.ship = Ship(self)
        
        
    def run_game(self):
        """Starts the main loops for the game"""
        while True:
            self._check_events() #To call a method from within the class, use dot notation with the vairiable self and the name of the method 
            self.ship.update()
            self._update_screen()            
            self.clock.tick(60) #set clock (frame rate) to 60 frames per second (tick takes one argument that sets frame rate)
            
    
    def _check_events(self):
         #watch for keyboard and mouse events
            for event in pygame.event.get(): #event is action that the user perfroms during game play
                if event.type == pygame.QUIT:
                    sys.exit()
                elif event.type == pygame.KEYDOWN:
                    self._check_keydown_events(event)
                elif event.type == pygame.KEYUP:
                    self._check_keyup_events(event)
                    
                        
    def _check_keydown_events(self, event):
        """Responds to key presses"""
        if event.key == pygame.K_RIGHT:
            self.ship.moving_right = True
        elif event.key == pygame.K_LEFT:
            self.ship.moving_left = True
        elif event.key == pygame.K_q: #Quits game by pressing 'q'
            sys.exit()
            
        
    def _check_keyup_events(self, event):
        """Responds to key releases"""                   
        if event.key == pygame.K_RIGHT:
            self.ship.moving_right = False
        elif event.key == pygame.K_LEFT:
            self.ship.moving_left = False
                            
    
    def _update_screen(self):
        """Updates images on the screen and flips to the new screen""" 
        #Redraw screen during each pass of the loop. fill method takes one argument: color
        self.screen.fill(self.settings.bg_color) 
        self.ship.blitme()                 
        #Make the most recently drawn screen visible
        pygame.display.flip()    
        
              
if __name__ == '__main__': 
    #Make game instance and run game
    ai = AlienInvasion()
    ai.run_game()

        