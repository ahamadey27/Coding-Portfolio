print("Line One\n\tsubline 1\n\tsubline 2") #Creating a new line and an indent on a new line

whiteSpace = ' whitespace is here '
print(whiteSpace.rstrip()) #remove white space to the right

whiteSpace = whiteSpace.lstrip() #remove whitespace to the left

print(whiteSpace)

urlExample = 'http://removehttp.com'
urlExample = urlExample.removeprefix('http://') #removes the prefix between the parenthesis
print(urlExample)