ABOUT
-------------------------------------------
This is my second attempt at making a Calculator in C#. 

There are two versions of my calculator on my github. Calculator 1.0 and Calulator 2.0.

I decided to re-attempt making a calculator due to how my previous calculator worked:

	1. It would ask the user what type of operation they would like to perform before hand
	2. It would then use a method based on whichever option they chose
	
However, I thought that this is not the most user friendly method of approaching this, and is also not how calculators work in real life. They should be 
able to tell what kind of operation the user would like to perform based on the symbol in between the two numbers, and then use the corresponding method, 
rather than manually asking the user, creating another unnecessary step in the process.


NEW COMMANDS LEARNED DURING PROJECT
-------------------------------------------
* .Split() - Splits a string into sub strings based on user specified chracter/s
* .Contains() - Returns a value based on whether or not a specified character is found within the string
* .Empty() - Represents an empty string
* .Parse() - Converts a string to an int 
* .Replace() - Returns a new string in which all occurences of a specified character or string are replaced with another specified character or string


IMPROVEMENTS TO BE MADE
-------------------------------------------
* I would like the user to be able to do repeat calculations with the previous answer if they wish
* I would to implement a calulation history, providing a user a list of all of their previous calculations
* I would like to replace the text regarding the previous calculation in the console with the new calculation
