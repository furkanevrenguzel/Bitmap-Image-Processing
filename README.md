# GaMP-Intern-Position-Task
As a programmer in a forensic laboratory, I have been asked to write a function to decode a bitmap image of a digital clock to determine what time it was when the image was created. The bitmap image has been converted to a string of binary digits 0 or 1 where 0 represents a white background pixel and 1 represents a black pixel. I convert this binary string into a time in hours and minutes in the form hh:mm (e.g. 09:47).

The clock face shows the time in a black on white background where each character is three cells wide and five cells deep. There is a space between the numbers represented by a column of blank cells:

The first three columns show the number 0, this is followed by a column of all 0 representing a space between the numbers, then comes another three columns representing the number 1, then three columns representing the character: then three columns representing 3, a column of zeroes representing a space and finally three columns representing the number 5. The resulting time is 01:35.

Task 2: Binary string must be retrieved from the user in the frontend section, not from the program as hardcode.

Project Output

![first_ss](https://user-images.githubusercontent.com/69848948/112731547-0f7a7400-8f49-11eb-8c1a-c142cf48b556.PNG)

![second_ss](https://user-images.githubusercontent.com/69848948/112731556-1ef9bd00-8f49-11eb-8b28-8992fbbb6892.PNG)
