def make_album(artist_name, album_name, track_number = None):
    """Return dictionary information about artist"""
    album_info = {
        'Artist' : artist_name.title(), 
        'Album' : album_name.title(),}
    if track_number:
        album_info['Tracks'] = track_number
    return album_info     

artist_prompt = "\nWhat arist are you thinking of? "
album_prompt = "And what album are you thinking of? "

print("\nAt any time press 'q' to quit")

while True:
    artist_name = input(artist_prompt)
    if artist_prompt == 'q':
        break
    
    album_name = input(album_prompt)
    if album_prompt == 'q':
        break
    
    album = make_album(artist_name, album_name)
    print(album)
    

    
    
    
