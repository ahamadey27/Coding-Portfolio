def make_album(artist_name, album_name, track_number = None):
    """Return dictionary information about artist"""
    album_info = {'Artist' : artist_name.title(), 'Album'.title(): album_name.title()}
    if track_number:
        album_info['Tracks'] = track_number
    return album_info             

album = make_album('the beatles', 'rubber soul', track_number=34)
print(album)

album = make_album('the band', 'ep')
print(album)