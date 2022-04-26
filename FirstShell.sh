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