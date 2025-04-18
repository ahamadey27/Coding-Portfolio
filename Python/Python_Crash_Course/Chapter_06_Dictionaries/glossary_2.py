glossary = {
    'hammer': 'Item that smashes things',
    'screw': 'Somethig that holds things.',
    'nail': 'What a hammer uses',
    'cat': 'An animal that meows',
    'dog': 'An animal that sniffs stuff',
}

for glos_name, glos_def in glossary.items():
    print(f"\nWord: {glos_name.title()}")
    print(f"Definition: {glos_def}")