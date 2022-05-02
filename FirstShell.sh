# This is a comment
# It is like putting a sticky note to your code to give a more meaningful message
# Of what you are doing in this script
# Echo is a way for us to give feedback to the person running the shell scripting
echo "This is your first shell script"

# Variables
msg="Hellow World Variable"
echo $msg # $ Syntax is what need to write to specify that we are referencing a variable

# Control Flow
# They are a way to tell the program to run multiple lines of code multiple times or
# We can tell the program to run linkes of code ir a condition is met

# If Statements
ten=10
five=5
thirteen=13

echo "===First If==="
if [ "$five" -ge "$ten" ] # -ge stands for greater than symbol or >
then
# Anything inside the then and fi is what is affected by the if statement
echo "Greater!"
echo "$ten > $five"
fi

echo "This is outside of the fi"

echo "===Second IF==="

if [ "$five" > "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -le "$ten" ] # elif will check its condition only if the previous if has failed
then
echo "Lesser!"
echo "$five < $ten"
fi

echo "===Third If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -ge "$thriteen" ]
then
echo "Greater!"
echo "$five > $thirteen"
else # else will run only if all previous conditions have failed
echo "Nothing Matches"
fi

# Loops Statement
# A way to repeat multiple lines of code

# For Loops statement
# Will repeat x amount of times
# Useful if you know how many times you need to execute those lines of code

echo "===For Loops==="
echo "===First Loop==="
for number in 10 2 World 1 2
do
echo "Hello $number"
echo "World"
echo "Testing"
echo "Line 4"
done

echo "===Second Loop==="
for i in {1..10}
do
echo "$i"
done

echo "===While Loops==="
# While Loop statement
# Will repeat you lines of code multiple times as long as the condition is true
# Useful if you don't know how many times you need to execute those lines of code

while [ "$five" -le "$ten" ]
do
echo "Lesser!"
five=$(($five+1)) # $((mathmatical operation)) syntax is how we can do math stuff
echo "$five"
done

# Input and Output
# We can ask for input from the user that is using the shell scripting and output some sort of response
echo "What is your name?"
#read name # Read [whatever variable name you specify] will store the user input in that variable

echo "Hello $name, Welcome to programming!"

# Making a shell Menu
clear # clear command will clear all the text in the terminal
repeat="true"

while [ "$repeat" == "true" ]
do
echo "Welcome to shell scripting"
echo "What do you want to do today?"
echo "enter 1 for adding two numbers?"
echo "enter 2 to exit"

read answer
if [ "$answer" == "1" ]
then
    echo "Give me number 1"
    read num1
    echo "Give me number 2"
    read num2
    echo "The sum is $(($num1+$num2))"
elif [ "$answer" == "2" ]
then
    repeat="false"
else
    echo "Please enter a correct option"
fi

done

repeat="true"

list="Gundam Breaker, Gundam Barbatos, Gundam Astraea, Gundam Schwarzritter, Gundam Phoenix Unicor"
Breaker="26"
Barbatos="70" 
Astraea="52"
Schwarzritter="400"
Phoenix="2754"
total = "0"

while [ "$repeat" == "true" ]
do
echo "Welcome to Gundam Haven!"
echo "Which Gundam Model were you interested in today?"
echo "Enter 1 for Gundam list"
echo "Enter 2 to checkout"

read answer
if [ "$answer" == "1" ]
then
    
    echo "Here are the items currently available" 
    echo "Gundam Breaker"
    echo "Gundam Barbatos"
    echo "Gundam Astraea"
    echo "Gundam Schwarzritter"
    echo "Gundam Phoenix Unicorn"
    read answer
fi

if [ "$answer" == "Breaker" ]
then
    echo "Your current total is $(($total+$Breaker))"
    total = $(($total+$Breaker))
fi

if [ "$answer" == "Barbatos" ]
then
    echo "Your current total is $(($total+$Barbatos))"
    
fi

if [ "$answer" == "Astraea" ]
then
    echo "Your current total is $(($total+$Astraea))"
    
fi

if [ "$answer" == "Schwarzritter" ]
then 
    echo "Your current total is $(($total+$Schwarzritter))"
    
fi

if [ "$answer" == "Phoenix" ]
then
    echo "Your current total is $(($total+$Phoenix))"
    
fi

if [ "$answer" == "2" ]
then
    echo "Would you like to checkout? Your current total is $(($total))"
    echo "Thank you for your purchase"

    repeat="false"
else
    echo "Please choose from the existing list"    
fi

done