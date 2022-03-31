#! /usr/bin/bash

# print Hello world 
# echo "Hello World "

# echo "My shell name is $BASH"
# echo "My shell version is $BASH_VERSION"
# echo "my current directory is $PWD"
# echo  "My home directory is $HOME"


read -p "Enter a dollar amount" VAR

#read VAR 
if (($VAR % 15 == 0 ));
then echo "Fizzbuzz";
 


elif (($VAR % 3 == 0 )); 

then
echo "Fizz";


elif (($VAR % 5 == 0 ));
then echo "Buzz";

else 
echo "invalid entry"
fi 



# echo "Fizz" # If 
# echo "Buzz" # If _USD % 5
# echo "FizzBuzz" # If _USD is %3 AND %5
# read -p "Your number" print
# read print $


